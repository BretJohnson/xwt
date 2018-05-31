//
// Application.cs
//
// Author:
//       Bret Johnson <bretjohn@xamarin.com>
//
// Copyright (c) 2018 Microsoft
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


using Xwt.Drawing;

namespace Xwt.WPFBackend
{
	/// <summary>
	/// This interface provides a way for Xwt widgets to assume the right themed look when running
	/// inside of Visual Studio. If the client app uses Xwt for Visual Studio UI, it should implement
	/// this interface and set it on the global Context.IVisualStudioResourceProvider. Conceptually,
	/// this can apply to both VSWindows and VSMac, but the current implementation is only for VSWindows,
	/// for WPF UI for a handful of widgets.
	/// </summary>
	public abstract class WPFThemedResourceProvider
	{
#if false
		/// <summary>
		/// Get the color given a VS themed color name (e.g. "Environment.CommandBarSelectedColor").
		/// See https://docs.microsoft.com/en-us/visualstudio/extensibility/ux-guidelines/shared-colors-for-visual-studio
		/// for a (partial) list of themed colors, for VSWin.
		/// </summary>
		/// <param name="colorName">VS color name </param>
		/// <returns>themed color</returns>
		public abstract Color GetColor (string colorName);
#endif

		public abstract object MenuItemTemplateKey { get; }

		public abstract object MenuItemSeparatorStyleKey { get; }

		public abstract object ContextMenuStyleKey { get; }
	}

	public enum VSPlatform
	{
		Windows,
		Mac
	}
}
