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
	[Register("SWRevealViewControllerDelegate", false)]
	[Model]
	public unsafe partial class SWRevealViewControllerDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWRevealViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SWRevealViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SWRevealViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("revealController:animationControllerForOperation:fromViewController:toViewController:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewControllerAnimatedTransitioning RevealController (SWRevealViewController revealController, SWRevealControllerOperation operation, global::UIKit.UIViewController fromVC, global::UIKit.UIViewController toVC)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:animateToPosition:")]
		[CompilerGenerated]
		public virtual void RevealControllerAnimateToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:didAddViewController:forOperation:animated:")]
		[CompilerGenerated]
		public virtual void RevealControllerDidAddViewController (SWRevealViewController revealController, global::UIKit.UIViewController viewController, SWRevealControllerOperation operation, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:didMoveToPosition:")]
		[CompilerGenerated]
		public virtual void RevealControllerDidMoveToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureBegan:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureBegan (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureBeganFromLocation:progress:overProgress:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureBeganFromLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress, global::System.nfloat overProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureBeganFromLocation:progress:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureBeganFromLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureEnded:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureEnded (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureEndedToLocation:progress:overProgress:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureEndedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress, global::System.nfloat overProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureEndedToLocation:progress:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureEndedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureMovedToLocation:progress:overProgress:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureMovedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress, global::System.nfloat overProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureMovedToLocation:progress:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureMovedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool RevealControllerPanGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer (SWRevealViewController revealController, global::UIKit.UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureShouldBegin:")]
		[CompilerGenerated]
		public virtual bool RevealControllerPanGestureShouldBegin (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:tapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool RevealControllerTapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer (SWRevealViewController revealController, global::UIKit.UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerTapGestureShouldBegin:")]
		[CompilerGenerated]
		public virtual bool RevealControllerTapGestureShouldBegin (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:willAddViewController:forOperation:animated:")]
		[CompilerGenerated]
		public virtual void RevealControllerWillAddViewController (SWRevealViewController revealController, global::UIKit.UIViewController viewController, SWRevealControllerOperation operation, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:willMoveToPosition:")]
		[CompilerGenerated]
		public virtual void RevealControllerWillMoveToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SWRevealViewControllerDelegate */
}
