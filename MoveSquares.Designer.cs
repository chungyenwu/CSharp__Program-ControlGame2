namespace Problem2
{
	partial class MoveSquares
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.m_tmrMove = new System.Windows.Forms.Timer( this.components );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "MoveSquares";

			// 
			// m_tmrMove
			// 
			this.m_tmrMove.Interval = 30;
			this.m_tmrMove.Tick += new System.EventHandler( this.MoveContinuous );
		}

		#endregion
		private System.Windows.Forms.Timer m_tmrMove;
	}
}

