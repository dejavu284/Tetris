using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris : Form
    {
        public void Window(){
            int[,] matrix = new int[10,20];
        }
        public void LFigure() {
            int[,] figure =
            {
                {1,0,0 },
                {1,0,0 },
                {1,1,0 }
            };
        }
        public void JFigure(){
            int[,] figure =
            {
                {0,0,1 },
                {0,0,1 },
                {0,1,1 }
            };
        }
        public void LineFigure(){
            int[,] figure =
            {
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 },
                {1,0,0,0 }
            };
        }
        public void SquearFigure(){
            int[,] figure =
            {
                {1,1 },
                {1,1 }
            };
        }
        public void TFigure(){
            int[,] figure =
            {
                {1,0,0 },
                {1,1,0 },
                {1,0,0 }
            };
        }
        public void SFigure(){ 
            int[,] figure =
            {
                {0,0,0 },
                {0,1,1 },
                {1,1,0 }
            };
        }
        public void ZFigure(){
            int[,] figure =
            {
                {0,0,0 },
                {1,1,0 },
                {0,1,1 }
            };
        }
        public void MatrixTransponision2X2(int [,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < i; j++){
                    (matrix[i,j], matrix[j,i]) = (matrix[j,i],matrix[i, j]);
                }
            }
        }
        public void MatrixTransponision3X3(int[,] matrix){
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < i; j++){
                    (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
                }
            }
        }
        public Tetris()
        {
            InitializeComponent();
            Size = new Size(300, 600);
        }

        private void Tetris_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tetris_Resize(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
