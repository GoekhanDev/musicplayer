using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace RecodedMusicPlayer.Models
{
    public class CustomSlider : Slider
    {
        //Source: https://stackoverflow.com/a/34703888/11996332
        private Binding SupressedBinding { get; set; }

        protected override void OnThumbDragStarted(DragStartedEventArgs e)
        {
            base.OnThumbDragStarted(e);
            var expression = BindingOperations.GetBindingExpression(this, ValueProperty);
            if (expression != null)
            {
                SupressedBinding = expression.ParentBinding;
                //clearing the binding will cause the Value to reset to default,
                //so we'll need to restore it
                var value = Value;
                BindingOperations.ClearBinding(this, ValueProperty);
                SetValue(ValueProperty, value);
            }
        }

        protected override void OnThumbDragCompleted(DragCompletedEventArgs e)
        {
            if (SupressedBinding != null)
            {
                //again, restoring the binding will cause the Value to update to source's
                //value (which is "out of date" by now), so we'll need to restore it
                var value = Value;
                BindingOperations.SetBinding(this, ValueProperty, SupressedBinding);
                SetCurrentValue(ValueProperty, value);
                SupressedBinding = null;
            }
            base.OnThumbDragCompleted(e);
        }
    }
}
