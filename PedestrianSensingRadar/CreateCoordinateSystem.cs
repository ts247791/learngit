using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setRadar
{
    class CreateCoordinateSystem
    {
        //创建坐标系
        public void drawCoordinate(Graphics g)//创建坐标系方法（xbuf,ybuf绘制点坐标数组）
        {
            //定义画刷
            Brush brush1 = new SolidBrush(Color.Black);
            Brush brush2 = new SolidBrush(Color.SaddleBrown);
            //定义画笔
            Pen mypen = new Pen(brush1, 1);
            Pen mypen2 = new Pen(Color.Black, 3);
         
            //定义字体
            Font font = new System.Drawing.Font("Arial", 9, FontStyle.Regular);
          
            //清空图片背景色
            g.Clear(Color.White);
            float W = g.VisibleClipBounds.Width;
            float H = g.VisibleClipBounds.Height;
            //创建点
            PointF center_Pt = new PointF(W / 2, H / 2);//定义原点（中心点）
            PointF center_S = new PointF(W / 2, H);//中心线起点
            PointF center_E = new PointF(W / 2, 0);//中心线终点
            float Xaxis_length = 7 * W / 16;//X轴端点距离中心点的长度
            float Yaxis_length = 5 * H / 12;//Y轴端点距离中心点的长度
            PointF Xaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y + Yaxis_length);//X轴首端点
            PointF Xaxis_EndPt = new PointF(center_Pt.X + Xaxis_length, center_Pt.Y + Yaxis_length);//X轴末端点

            PointF Yaxis_Begin = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y + Yaxis_length);//Y轴首端点
            PointF Yaxis_EndPt = new PointF(center_Pt.X - Xaxis_length, center_Pt.Y - Yaxis_length);//Y轴末端点

            //①绘制由坐标对、宽度和高度指定的矩形(  x,  y, width, height)（绘制边框线）
            //g.DrawRectangle(mypen2, Xaxis_Begin.X, Yaxis_EndPt.Y, W - W / 8, H - H / 6);
            //g.DrawRectangle(mypen2, Xaxis_Begin.X, Yaxis_EndPt.Y, W, H);
            //② 画X轴    画Y轴        
            //g.DrawLine(Pens.Black, Xaxis_Begin.X, Xaxis_Begin.Y, Xaxis_EndPt.X, Xaxis_EndPt.Y);//X轴首 末=左右
            //g.DrawLine(Pens.Black, Yaxis_Begin.X, Yaxis_Begin.Y, Yaxis_EndPt.X, Yaxis_EndPt.Y);//Y轴首 末=上下
            //绘中心线
            g.DrawLine(Pens.Red, W / 2, H, W / 2, 0);

            //添加背景颜色
            //g.FillRectangle(brush1, Xaxis_Begin.X + 1, Yaxis_EndPt.Y + 1, W - W / 8, H - H / 6);
            //g.FillRectangle(brush1, Xaxis_Begin.X + 1, Yaxis_EndPt.Y + 1, W, H);


            //刻度
            //x轴上对应的标记
            /*
            String[] n = { "-14", "-12", "-10", "-8", "-6", "-4", "-2", " 0", " 2", " 4", " 6", " 8", " 10", " 12", " 14" };
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）
            //x和y为首个刻度的位置，15为刻度总数，(W-50)/15为刻度间隔
            float x = Xaxis_Begin.X;

            for (int i = 0; i < 15; i++)
            {
                g.DrawString(n[i].ToString(), font, Brushes.Red, x, H - H / 12);
                x = x + W / 16;
            }
            */
            //y轴上对应的标记
            String[] m = { "-50米", "-40米", "-30米", "-20米", "-10米"};
            //设置文字内容及输出位置（DrawString 在指定位置输出文本）

            float y = 0;
            for (int i = 0; i < 6; i++)
            {
                g.DrawString(m[i].ToString(), font, Brushes.Red, 0, y);
                y = y + H / 5;
            }
            g.Save();
            brush1.Dispose();
            brush1 = null;
            brush2.Dispose();
            brush1 = null;
            mypen.Dispose();
            mypen = null;
        }
    }
}
