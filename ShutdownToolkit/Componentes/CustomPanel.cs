using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShutdownToolkit.Componentes
{
    class CustomPanel : Panel
    {

        #region ..:: Variables ::..

        private int _borderSize = 0;
        private int _radiusSize = 0;
        private Color _borderColor = Color.FromArgb(66, 66, 66);

        #endregion ..:: Variáveis ::..

        #region ..:: Properties ::..

        [Category("ShutdownToolkit - Properties")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }
        [Category("ShutdownToolkit - Properties")]
        public int RadiusSize
        {
            get { return _radiusSize; }
            set
            {
                _radiusSize = value;
                this.Invalidate();
            }
        }
        [Category("ShutdownToolkit - Properties")]
        public Color CorBorda
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }
        [Category("ShutdownToolkit - Properties")]
        public Color ButtonColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("ShutdownToolkit - Properties")]
        public Color ButtonTextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion

        #region ..:: Constructor ::..

        public CustomPanel()
        {
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(66, 66, 66);
            this.ForeColor = Color.WhiteSmoke;
            this.Resize += new EventHandler(Panel_Resize);
        }

        #endregion 

        #region ..:: Methods ::..

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (_radiusSize > this.Height)
                _radiusSize = this.Height;
        }

        private GraphicsPath GetFigurePath(Rectangle retangulo, float raio)
        {
            GraphicsPath raphicsPath = new GraphicsPath();
            float curveSize = raio * 2F;
            raphicsPath.StartFigure();
            raphicsPath.AddArc(retangulo.X, retangulo.Y, curveSize, curveSize, 180, 90);
            raphicsPath.AddArc(retangulo.Right - curveSize, retangulo.Y, curveSize, curveSize, 270, 90);
            raphicsPath.AddArc(retangulo.Right - curveSize, retangulo.Bottom - curveSize, curveSize, curveSize, 0, 90);
            raphicsPath.AddArc(retangulo.X, retangulo.Bottom - curveSize, curveSize, curveSize, 90, 90);
            raphicsPath.CloseFigure();
            return raphicsPath;
        }

        protected override void OnPaint(PaintEventArgs pEvento)
        {
            base.OnPaint(pEvento);
            Rectangle rectangleSurface = this.ClientRectangle;
            Rectangle rectangleBorder = Rectangle.Inflate(rectangleSurface, -_borderSize, -_borderSize);
            int suavidadeBorda = 2;
            if (_borderSize > 0)
                suavidadeBorda = _borderSize;
            if (_radiusSize > 2)
            {
                using (GraphicsPath gpSuperficie = GetFigurePath(rectangleSurface, _radiusSize))
                using (GraphicsPath pBorda = GetFigurePath(rectangleBorder, _radiusSize - _borderSize))
                using (Pen penSuperficie = new Pen(this.Parent.BackColor, suavidadeBorda))
                using (Pen penBorda = new Pen(_borderColor, _borderSize))
                {
                    pEvento.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    this.Region = new Region(gpSuperficie);

                    pEvento.Graphics.DrawPath(penSuperficie, gpSuperficie);

                    if (_borderSize >= 1)
                        pEvento.Graphics.DrawPath(penBorda, pBorda);
                }
            }
            else
            {
                pEvento.Graphics.SmoothingMode = SmoothingMode.None;

                this.Region = new Region(rectangleSurface);

                if (_borderSize >= 1)
                {
                    using (Pen penBorda = new Pen(_borderColor, _borderSize))
                    {
                        penBorda.Alignment = PenAlignment.Inset;
                        pEvento.Graphics.DrawRectangle(penBorda, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        #endregion ..:: Métodos ::..
    }
}
