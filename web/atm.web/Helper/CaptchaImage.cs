using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SevenH.MMCSB.Atm.Web
{
    public class CaptchaImage
    {
        public Bitmap Image => this.m_image;

        private string m_text;
        private readonly int m_width;
        private readonly int m_height;
        private readonly FontFamily m_fontFamily;
        private Bitmap m_image;

        private readonly Random m_random = new Random( );

        public CaptchaImage( int width, int height, FontFamily fontFamily )
        {
            this.m_width = width;
            this.m_height = height;
            this.m_fontFamily = fontFamily;
        }
        public CaptchaImage( string s, int width, int height, FontFamily fontFamily )
        {
            this.m_text = s;
            this.m_width = width;
            this.m_height = height;
            this.m_fontFamily = fontFamily;
        }
        public string CreateRandomText( int length )
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ1234567890";
            char[] chars = new char[ length ];
            Random rd = new Random( );

            for ( int i = 0; i < length; i++ ) {
                chars[ i ] = allowedChars[ rd.Next( 0, allowedChars.Length ) ];
            }

            return new string( chars );
        }

        public void GenerateImage( )
        {
            // Create a new 32-bit bitmap image.
            Bitmap bitmap = new Bitmap( this.m_width, this.m_height, PixelFormat.Format32bppArgb );

            // Create a graphics object for drawing.
            Graphics g = Graphics.FromImage( bitmap );
            g.PageUnit = GraphicsUnit.Pixel;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle( 0, 0, this.m_width, this.m_height );

            // Fill in the background.
            HatchBrush hatchBrush = new HatchBrush( HatchStyle.Shingle, Color.LightGray, Color.White );
            g.FillRectangle( hatchBrush, rect );

            // Set up the text font.
            SizeF size;
            float fontSize = rect.Height + 1;
            Font font;
            // Adjust the font size until the text fits within the image.
            do {
                fontSize--;
                font = new Font( this.m_fontFamily.Name, fontSize, GraphicsUnit.Pixel );
                size = g.MeasureString( this.m_text, font );
            } while ( size.Width > rect.Width );

            // Set up the text format.
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Create a path using the text and warp it randomly.
            GraphicsPath path = new GraphicsPath( );

            path.AddString( this.m_text, font.FontFamily, (int)font.Style, font.Size, rect, format );
            float v = 4F;
            PointF[] points =
			{
				new PointF(this.m_random.Next(rect.Width) / v, this.m_random.Next(rect.Height) / v),
				new PointF(rect.Width - this.m_random.Next(rect.Width) / v, this.m_random.Next(rect.Height) / v),
				new PointF(this.m_random.Next(rect.Width) / v, rect.Height - this.m_random.Next(rect.Height) / v),
				new PointF(rect.Width - this.m_random.Next(rect.Width) / v, rect.Height - this.m_random.Next(rect.Height) / v)
			};
            Matrix matrix = new Matrix( );
            matrix.Translate( 0F, 0F );
            path.Warp( points, rect, matrix, WarpMode.Perspective, 0F );

            // Draw the text.
            hatchBrush = new HatchBrush( HatchStyle.Shingle, Color.LightGray, Color.DarkGray );
            g.FillPath( hatchBrush, path );

            // Add some random noise.
            int m = Math.Max( rect.Width, rect.Height );
            for ( int i = 0; i < (int)( rect.Width * rect.Height / 30F ); i++ ) {
                int x = this.m_random.Next( rect.Width );
                int y = this.m_random.Next( rect.Height );
                int w = this.m_random.Next( m / 50 );
                int h = this.m_random.Next( m / 50 );
                g.FillEllipse( hatchBrush, x, y, w, h );
            }

            // Clean up.
            font.Dispose( );
            hatchBrush.Dispose( );
            g.Dispose( );

            // Set the image.
            this.m_image = bitmap;
        }

        public void SetText( string text )
        {
            this.m_text = text;
        }
    }
}
