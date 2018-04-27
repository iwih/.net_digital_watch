using System;
using System.Drawing;
using System.Windows.Forms;
using JetBrains.Annotations;

namespace DigitalWatch
{
    public class FormMover : IDisposable
    {
        public bool IsActive { private set; get; }

        private readonly Form _formToMove;
        private readonly Control _moverControl;

        private int _deltaX;
        private int _deltaY;

        private bool _isMoveOn;

        public FormMover([NotNull] Form formToMove, [NotNull] Control moverControl)
        {
            _formToMove = formToMove;
            _moverControl = moverControl;
        }

        public void ActivateMover()
        {
            _moverControl.MouseDown += _moverControl_MouseDown;
            _moverControl.MouseUp += _moverControl_MouseUp;
            _moverControl.MouseMove += _moverControl_MouseMove;
            IsActive = true;
        }

        public void Deactivate()
        {
            if (!IsActive) return; // nothing to do
            //else unassign the event handlers
            _moverControl.MouseDown -= _moverControl_MouseDown;
            _moverControl.MouseUp -= _moverControl_MouseUp;
            _moverControl.MouseMove -= _moverControl_MouseMove;
        }

        private void _moverControl_MouseDown(object sender, MouseEventArgs e)
        {
            SetOn();
        }

        private void _moverControl_MouseUp(object sender, MouseEventArgs e)
        {
            SetOff();
        }

        private void _moverControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMoveOn)
            {
                if (_formToMove.WindowState == FormWindowState.Maximized)
                {
                    _formToMove.WindowState = FormWindowState.Normal;

                    var moverControlScreen = _moverControl.PointToScreen(_moverControl.Location);
                    if (Control.MousePosition.X > (moverControlScreen.X + _moverControl.Width))
                    {
                        var controlCenterToFormX =
                            moverControlScreen.X - _formToMove.Location.X + _moverControl.Width / 2;
                        var controlCenterToFormY =
                            moverControlScreen.Y - _formToMove.Location.Y + _moverControl.Height / 2;

                        var formX = Control.MousePosition.X - controlCenterToFormX;
                        var formY = Control.MousePosition.Y - controlCenterToFormY;

                        _formToMove.Location = new Point(formX, formY);
                        AssignDeltaXY();
                    }
                }

                _formToMove.Location =
                    new Point(
                        Control.MousePosition.X - _deltaX,
                        Control.MousePosition.Y - _deltaY);
            }
        }

        public void SetOn()
        {
            AssignDeltaXY();

            _isMoveOn = true;
        }

        private void AssignDeltaXY()
        {
            _deltaX = Control.MousePosition.X - _formToMove.Location.X;
            _deltaY = Control.MousePosition.Y - _formToMove.Location.Y;
        }

        public void SetOff()
        {
            _isMoveOn = false;
        }

        public void Dispose()
        {
            _moverControl.MouseDown -= _moverControl_MouseDown;
            _moverControl.MouseUp -= _moverControl_MouseUp;
            _moverControl.MouseMove -= _moverControl_MouseMove;
            IsDisposed = true;
        }

        public bool IsDisposed { set; get; }
    }
}