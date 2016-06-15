using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding;
using MvvmCross.Binding.Droid.Target;

namespace RecyclerVIewSample.Droid.Binding
{
    public class UrlImageViewImageUrlTargetBinding : MvxAndroidTargetBinding
    {
        public UrlImageViewImageUrlTargetBinding(CustomImageView target)
            : base(target)
        {
        }

        /// <summary>
        /// Gets the target type.
        /// </summary>
        public override Type TargetType => typeof(string);

        /// <summary>
        /// Gets the default mode.
        /// </summary>
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        /// <summary>
        /// Gets the SlgImageView.
        /// </summary>
        /// <value>
        /// The SLG image view.
        /// </value>
        protected CustomImageView SlgImageView => this.Target as CustomImageView;

        /// <summary>
        /// The set value impl.
        /// </summary>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="toSet">
        /// The to set.
        /// </param>
        protected override void SetValueImpl(object target, object toSet)
        {
            var value = (string)toSet;
            this.SlgImageView.ImageUrl = value;
        }
    }
}