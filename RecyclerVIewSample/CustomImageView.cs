using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using FFImageLoading;
using FFImageLoading.Views;

namespace RecyclerVIewSample.Droid
{
    [Register("recyclerviewsample.droid.controls.CustomImageView")]
    public class CustomImageView : ImageViewAsync
    {
        private string imageUrl;

        private bool lazyLoading;

        public CustomImageView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }


        public CustomImageView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            this.ViewTreeObserver.PreDraw += ViewTreeObserverOnPreDraw;
            this.Init(context, attrs);
        }

        public CustomImageView(Context context) : base(context)
        {
        }

        public bool IsViewLoaded { get; private set; }


        public string ImageUrl
        {
            get { return this.imageUrl; }

            set
            {
                this.imageUrl = value;
                if (!this.lazyLoading || this.IsViewLoaded)
                    this.LoadImageRealy();
            }
        }

        
        public string ErrorImagePath { get; set; }

        
        public string DefaultImagePath { get; set; }

        private void ViewTreeObserverOnPreDraw(object sender, ViewTreeObserver.PreDrawEventArgs preDrawEventArgs)
        {
            if (this.lazyLoading && !this.IsViewLoaded)
            {
                this.LoadImageRealy();
            }
            this.IsViewLoaded = true;
        }

        
        protected virtual void LoadImageRealy()
        {
            var url = this.imageUrl ?? string.Empty;
            var task = ImageService.Instance.LoadUrl(url);

            if (!string.IsNullOrEmpty(this.ErrorImagePath))
                task.ErrorPlaceholder(this.ErrorImagePath, FFImageLoading.Work.ImageSource.ApplicationBundle);

            if (!string.IsNullOrEmpty(this.DefaultImagePath))
                task.LoadingPlaceholder(this.DefaultImagePath, FFImageLoading.Work.ImageSource.ApplicationBundle);

            if (this.lazyLoading && (this.Width > 0 || this.Height > 0))
                task.DownSample(this.Width, this.Height);

            task.Into(this);
        }

        private void Init(Context context, IAttributeSet attrs)
        {
            var array = context.ObtainStyledAttributes(attrs, Resource.Styleable.CustomImageView);

            for (var i = 0; i < array.IndexCount; ++i)
            {
                var attr = array.GetIndex(i);
                switch (attr)
                {
                    case Resource.Styleable.CustomImageView_lazyLoading:
                        this.lazyLoading = array.GetBoolean(attr, false);
                        break;
                    case Resource.Styleable.CustomImageView_defaultImagePath:
                        this.DefaultImagePath = array.GetString(attr);
                        break;
                    case Resource.Styleable.CustomImageView_errorImagePath:
                        this.ErrorImagePath = array.GetString(attr);
                        break;
                }
            }

            array.Recycle();
        }
    }
}