// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Playground.TvOS
{
    [Register ("ModalView")]
    partial class ModalView
    {
        [Outlet]
        UIKit.UIButton btnClose { get; set; }


        [Outlet]
        UIKit.UIButton btnNestedModal { get; set; }


        [Outlet]
        UIKit.UIButton btnTabNav { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnClose != null) {
                btnClose.Dispose ();
                btnClose = null;
            }

            if (btnNestedModal != null) {
                btnNestedModal.Dispose ();
                btnNestedModal = null;
            }

            if (btnTabNav != null) {
                btnTabNav.Dispose ();
                btnTabNav = null;
            }
        }
    }
}