using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBindingApp
{
    class MyTextBlock : FrameworkElement
    {
        public static readonly DependencyProperty TextProperty;

        static MyTextBlock()
        {
            TextProperty = DependencyProperty.Register(
                "Text",
                typeof(string),
                typeof(MyTextBlock),
                new FrameworkPropertyMetadata(
                    String.Empty,
                    FrameworkPropertyMetadataOptions.AffectsMeasure |
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    new PropertyChangedCallback(OnTextChanged),
                    new CoerceValueCallback(CoerceText)
                    )
                );
        }

        public string Text
        {
            get => (string)GetValue( TextProperty );
            set => SetValue( TextProperty, value );
        }

        static object CoerceText(DependencyObject d, object value )
        {
            return null;
        }

        static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
