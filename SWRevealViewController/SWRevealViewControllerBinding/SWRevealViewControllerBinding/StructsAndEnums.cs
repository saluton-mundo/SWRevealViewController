using System;
using ObjCRuntime;

namespace SWRevealViewControllerBinding
{
    [Native]
    public enum FrontViewPosition : ulong
    {
        LeftSideMostRemoved,
        LeftSideMost,
        LeftSide,
        Left,
        Right,
        RightMost,
        RightMostRemoved
    }

    [Native]
    public enum SWRevealToggleAnimationType : ulong
    {
        Spring,
        EaseOut
    }

    public enum SWRevealControllerOperation : uint
    {
        None,
        ReplaceRearController,
        ReplaceFrontController,
        ReplaceRightController
    }
}