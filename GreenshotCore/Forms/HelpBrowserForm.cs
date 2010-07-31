/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2010  Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on Sourceforge: http://sourceforge.net/projects/greenshot/
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.IO;
using Greenshot.Configuration;
using Greenshot.Core;

namespace Greenshot.Forms {
	/// <summary>
	/// Description of HelpBrowserForm.
	/// </summary>
	public partial class HelpBrowserForm {
		private ILanguage lang;
		public HelpBrowserForm(string language) {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
						
			lang = Language.GetInstance();
			
			webBrowser1.Url = new Uri(Path.Combine("path://", lang.GetHelpFilePath()));
			
			updateUI();
		}
		
		private void updateUI() {
			
			this.Text = lang.GetString(LangKey.help_title);
		}
	}
}