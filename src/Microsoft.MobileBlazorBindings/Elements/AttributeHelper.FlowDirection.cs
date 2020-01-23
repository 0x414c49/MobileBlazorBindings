using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public static partial class AttributeHelper
    {
        /// <summary>
        /// Helper method to serialize <see cref="FlowDirection" /> enums.
        /// </summary>
        public static string FlowDirectionToString(FlowDirection flowDirection)
        {
            return flowDirection.ToString();
        }

        /// <summary>
        /// Helper method to deserialize <see cref="FlowDirection" /> objects.
        /// </summary>
        public static FlowDirection StringToFlowDirection(object flowDirection)
        {
            if (flowDirection is null)
            {
                throw new ArgumentNullException(nameof(flowDirection));
            }
            if (!(flowDirection is string flowDirectionAsString))
            {
                throw new ArgumentException("Expected parameter instance to be a string.", nameof(flowDirection));
            }
            if (!Enum.TryParse(flowDirectionAsString, out FlowDirection parsedFlowDirection))
            {
                throw new ArgumentException($"Expected parameter insanse only can be ${FlowDirection.RightToLeft}, ${FlowDirection.LeftToRight} and ${FlowDirection.MatchParent}");
            }
            return parsedFlowDirection;
        }
    }
}
