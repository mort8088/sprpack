#region MIT License
/*
 * Copyright (c) 2009-2010 Kelly Gravelyn (kelly@kellyrenee.me), Markus Ewald (cygon@nuclex.org)
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a 
 * copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation 
 * the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software 
 * is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all 
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 
 * 
 */
#endregion

using CommandLine;

namespace sprpack
{
	public class ProgramArguments
	{
		[Option(HelpText = "Output file name for the image.", Default = "Atlas.png")]
		public string image { get; set; }

	 	[Option(HelpText = "Output file name for the map.", Default = "Atlas_map.xml")]
	 	public string map { get; set; }

	 	[Option(HelpText = "Maximum output width.", Default = Constants.DefaultMaximumSheetWidth)]
	 	public int mw { get; set; }

	 	[Option(HelpText = "Maximum output height.", Default = Constants.DefaultMaximumSheetWidth)]
	 	public int mh { get; set; }

	 	[Option(HelpText = "Padding between images.", Default = Constants.DefaultImagePadding)]
	 	public int pad { get; set; }

	 	[Option(HelpText = "Ensures output dimensions are powers of two.", Default = false)]
	 	public bool pow2 { get; set; }

	 	[Option(HelpText = "Ensures output is square.", Default = false)]
	 	public bool sqr { get; set; }

	 	[Option("recursive", HelpText = "Searches subdirectories of any input directories.", Default = false)]
	 	public bool r { get; set; }

	 	[Option(HelpText = "Path to file listing the images to build.")]
	 	public string? il { get; set; }

		[Value(0, Required = false, HelpText = "Images to pack.")]
	 	public IEnumerable<string> input { get; set; }

		public ProgramArguments()
		{
			this.image = "Atlas.png"; 
			this.map = "Atlas_map.xml";
			this.mw = Constants.DefaultMaximumSheetWidth;
			this.mh = Constants.DefaultMaximumSheetWidth;
			this.pad = Constants.DefaultImagePadding;
			this.pow2 = false;
			this.sqr = false;
			this.r = false;
			this.input = new List<string>();
		}
	}
}