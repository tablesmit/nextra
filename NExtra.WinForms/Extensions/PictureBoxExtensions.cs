using System.Windows.Forms;
using NExtra.WinForms.Printing;

namespace NExtra.WinForms.Extensions
{
	/// <summary>
	/// Extension methods for System.Windows.Forms.PictureBox.
	/// </summary>
	/// <remarks>
	/// Author:     Daniel Saidi [daniel.saidi@gmail.com]
	/// Link:       http://danielsaidi.github.com/nextra
	/// </remarks>
	public static class PictureBoxExtensions
	{
		/// <summary>
        /// Print the control, using a default PictureBoxPrinter instance.
		/// </summary>
		public static void Print(this PictureBox pictureBox)
		{
			pictureBox.Print(new PictureBoxPrinter(pictureBox));
		}

		/// <summary>
        /// Print the control, using a custom IControlPrinter instance.
		/// </summary>
        public static void Print(this PictureBox pictureBox, IControlPrinter<PictureBox> controlPrinter)
		{
			controlPrinter.TargetControl = pictureBox;
			controlPrinter.Print();
		}
	}
}