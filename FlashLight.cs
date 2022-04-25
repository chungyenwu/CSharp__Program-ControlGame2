using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Problem2
{
	public class FlashLight : Panel
	{
		public FlashLight( int nLocationLX, int nLocationLY, int nLH, int nLW )
		{
			this.BackColor = Color.Blue;
			this.BorderStyle = BorderStyle.FixedSingle;
			this.Location = new Point( nLocationLX, nLocationLY );
			this.Size = new Size( nLH, nLW );
		}

		public void LightOn( int nDist )
		{
			this.BackColor = Color.Red;
		}

		public void LightOff( int nDist )
		{
			this.BackColor = Color.Blue;
		}
	}
}
