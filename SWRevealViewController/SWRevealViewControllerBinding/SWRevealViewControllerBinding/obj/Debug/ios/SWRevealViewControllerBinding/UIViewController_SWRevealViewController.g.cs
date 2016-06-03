//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace SWRevealViewControllerBinding {
	public unsafe static partial class UIViewController_SWRevealViewController  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIViewController");
		
		[Export ("revealViewController")]
		[CompilerGenerated]
		public static SWRevealViewController RevealViewController (this global::UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<SWRevealViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("revealViewController")));
		}
		
	} /* class UIViewController_SWRevealViewController */
}
