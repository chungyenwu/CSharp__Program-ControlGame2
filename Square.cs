using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Problem2
{
	//Public Methods and Members
	public partial class Square : Panel
	{
		public Square( int nLocationSX, int nLocationSY, int nSizeX, int nSizeY )
		{
			//Gived Moving Speed
			m_nSquareSpeed = 8;

			//Make Square
			this.BackColor = Color.Blue;
			this.Location = new Point( nLocationSX, nLocationSY );
			this.Size = new Size( nSizeX, nSizeY );

			//Add Lights
			int nLightSizeX = nSizeX / 5;
			int nLightSizeY = nSizeY / 5;
			m_LightTop = new FlashLight( ( nSizeX - nLightSizeX ) / 2, nSizeX / 5, nLightSizeX, nLightSizeY );
			m_LightBottom = new FlashLight( ( nSizeX - nLightSizeX ) / 2, 3 * nSizeY / 5, nLightSizeX, nLightSizeY );

			this.Controls.Add( m_LightTop );
			this.Controls.Add( m_LightBottom );
		}

		
		public void MoveVertical( int nLimitationY )
		{
			if( m_nSquareSpeed > 0 ) {
				m_LightBottom.LightOn( m_nSquareSpeed );
				m_LightTop.LightOff( m_nSquareSpeed );
			}

			if( m_nSquareSpeed < 0 ) {
				m_LightTop.LightOn( m_nSquareSpeed );
				m_LightBottom.LightOff( m_nSquareSpeed );
			}

			if( ( Top + m_nSquareSpeed ) < 0 || ( Bottom + m_nSquareSpeed ) > nLimitationY ) {
				m_nSquareSpeed = -m_nSquareSpeed;
			}
			this.Top += m_nSquareSpeed;
		}
	}

	//Private Methods and Members
	public partial class Square : Panel
	{
		int m_nSquareSpeed;
		FlashLight m_LightTop;
		FlashLight m_LightBottom;
	}
}
