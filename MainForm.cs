/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/3/2024
 * Time: 12:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace collider
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private static double GetDistance(double x1, double y1, double x2, double y2)
		{
		   return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
		}
		
		public bool collideDots(int x1,int y1,int x2, int y2, int r)
		{
			if(x1==x2 && y1==y2){return true;}
			else{
				if(GetDistance(x1,y1,x2,y2)<r)
					{
						return true;
					}
					else 
					{
						return false;
					}
				}
			
		}
	}
}
