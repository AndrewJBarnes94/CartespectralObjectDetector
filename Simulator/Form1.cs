using OpenTK.GLControl;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;


namespace Simulator
{
    public partial class Form1 : Form
    {
        private GLControl glControl;

        public Form1()
        {
            InitializeComponent();
            InitGLControl();
        }

        private void InitGLControl()
        {
            glControl = new GLControl();
            glControl.Dock = DockStyle.Fill;
            glControl.Paint += GlControl_Paint;
            glControl.Resize += GlControl_Resize;
            this.Controls.Add(glControl);
        }

        private void GlControl_Paint(object sender, PaintEventArgs e)
        {
            GL.ClearColor(0.05f, 0.05f, 0.1f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl.SwapBuffers();
        }

        private void GlControl_Resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, glControl.Width, glControl.Height);
        }
    }

}
