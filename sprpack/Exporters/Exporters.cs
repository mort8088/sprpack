#region MIT License

/*
 * Copyright (c) 2009-2010 Kelly Gravelyn (kelly@kellyrenee.me), Markus Ewald (cygon@nuclex.org)
 * Copyright (c) 2022-2023 Dave Henry (dave@mort8088.com)
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

using System.Collections.ObjectModel;
using System.Reflection;

namespace sprpack
{
	public static class Exporters
	{
		private static List<IImageExporter> imageExporters = new List<IImageExporter>();
		private static List<IMapExporter> mapExporters = new List<IMapExporter>();

		public static ReadOnlyCollection<IImageExporter> ImageExporters { get; private set; }
		public static ReadOnlyCollection<IMapExporter> MapExporters { get; private set; }

		public static void Load() { /* invokes static constructor */ }

		static Exporters()
		{
			ImageExporters = new ReadOnlyCollection<IImageExporter>(imageExporters);
			MapExporters = new ReadOnlyCollection<IMapExporter>(mapExporters);

			// find built in exporters
			FindExporters(Assembly.GetExecutingAssembly());
		}

		private static void FindExporters(Assembly assembly)
		{
			try
			{
				imageExporters.Add(new PngImageExporter() as IImageExporter);
				
				mapExporters.Add(new XmlMapExporter() as IMapExporter);
			} catch {
				/* Don't care ATM */
			}
		}
	}
}
