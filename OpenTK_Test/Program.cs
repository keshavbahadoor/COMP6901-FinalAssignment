using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing; 


namespace OpenTK_Test
{
    class Program : GameWindow
    {
        public Program()
        {
            this.Size = new Size(1024, 768);
            GL.LineWidth(4F); 
        }

        protected override void OnResize(EventArgs e)
        {
            // Set orthographic rendering (useful when you want 2D)
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(this.ClientRectangle.Left, this.ClientRectangle.Right,
                this.ClientRectangle.Bottom, this.ClientRectangle.Top, -1.0, 1.0);
            GL.Viewport(this.ClientRectangle.Size);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //if (time == 0f)
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.Begin(BeginMode.Polygon);

            GL.Vertex2(0, 0);
            GL.Vertex2(Width, Height);

            GL.Vertex2(Width, 0);
            GL.Vertex2(0, Height);


            GL.End();


            SwapBuffers();
        }

        static void Main(string[] args)
        {
            using (Program p = new Program())
            {
                p.Run();
            }
        }
    }
}
