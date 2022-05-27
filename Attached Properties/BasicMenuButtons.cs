using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace epicRD.Attached_Properties
{
    internal class BasicMenuButtons : Button
    {


        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(BasicMenuButtons));



        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(BasicMenuButtons));





        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(BasicMenuButtons));





        public ImageSource ImageIcon
        {
            get { return (ImageSource)GetValue(ImageIconProperty); }
            set { SetValue(ImageIconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register("ImageIcon", typeof(ImageSource), typeof(BasicMenuButtons));



        public Brush IconFill
        {
            get { return (Brush)GetValue(IconFillProperty); }
            set { SetValue(IconFillProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFill.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register("IconFill", typeof(Brush), typeof(BasicMenuButtons));



        public Brush IconFillOnHover
        {
            get { return (Brush)GetValue(IconFillOnHoverProperty); }
            set { SetValue(IconFillOnHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFillOnHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFillOnHoverProperty =
            DependencyProperty.Register("IconFillOnHover", typeof(Brush), typeof(BasicMenuButtons));



        public Brush IconBackground
        {
            get { return (Brush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register("IconBackground", typeof(Brush), typeof(BasicMenuButtons));



        public Brush IconBackgroundHover
        {
            get { return (Brush)GetValue(IconBackgroundHoverProperty); }
            set { SetValue(IconBackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundHoverProperty =
            DependencyProperty.Register("IconBackgroundHover", typeof(Brush), typeof(BasicMenuButtons));


    }
}
