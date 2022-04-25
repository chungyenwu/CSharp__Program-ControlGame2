using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Problem2
{
	//Public Methods and Members
	public partial class MoveSquares : Form
	{
		public MoveSquares()
		{
			InitializeComponent();
			int nFormWidth = GAP_BETWEEN_BOUNDARY * 2 * ( SQUARE_NUMBER + 1 );
			this.ClientSize = new Size( nFormWidth, FORM_HEIGHT );
			this.KeyDown += new System.Windows.Forms.KeyEventHandler( MoveSquares_KeyDown );

			//Decide Start Or Not
			m_bStartArray = new bool[ SQUARE_NUMBER ];
			for( int nItem = 0; nItem < m_bStartArray.Length; nItem++ ) {
				m_bStartArray[ nItem ] = false;
			}

			//Make Squares
			int nFirstSquareY = 60;
			int nSquareGap = GAP_BETWEEN_BOUNDARY / 3;
			int nSquareSizeX = nSquareGap * 5;
			int nSquareSizeY = nSquareGap * 5;

			m_SquareList = new List<Square>();
			for( int nItem = 0; nItem < SQUARE_NUMBER; nItem++ ) {
				m_SquareList.Add( new Square( ( GAP_BETWEEN_BOUNDARY + nItem * ( nSquareGap + nSquareSizeX )), nFirstSquareY, nSquareSizeX, nSquareSizeY ) );
			}
			
			//Add The Object To Form
			for( int nItem = 0; nItem < m_SquareList.Count; nItem++ ) {
				this.Controls.Add( m_SquareList[ nItem ] );
			}
		}
	}

	//Private Methods and Members
	public partial class MoveSquares : Form
	{
		//Member Variable
		const int FORM_HEIGHT = 650;
		const int SQUARE_NUMBER = 10;
		const int GAP_BETWEEN_BOUNDARY = 60;
		const int MULT = 10;

		List<Square> m_SquareList;
		bool[] m_bStartArray;
		int m_nCount;

		void MoveSquares_KeyDown( object sneder, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.B ) {
				m_tmrMove.Enabled = true;
			}
			if( e.KeyCode == Keys.A ) {
				m_tmrMove.Enabled = false;
			}
		}

		void MoveContinuous( object sneder, EventArgs e )
		{
			//Define The Depart Time For Each Square
			if( m_nCount <= 100 ) {
				for( int nItem = 0; nItem < m_bStartArray.Length; nItem++ ) {
					if( m_nCount == ( nItem ) * MULT ) {
						m_bStartArray[ nItem ] = true;
					}
				}
				m_nCount++;
			}

			//Define The MoveMent For Each Square
			for( int nItem = 0; nItem < SQUARE_NUMBER; nItem++ ) {
				if( m_bStartArray[ nItem ] == false) {
					continue;
				}
				m_SquareList[ nItem ].MoveVertical( FORM_HEIGHT );
			}
		}
	}
}