namespace Quotes.Effects
{
    using Xamarin.Forms;

    public class ShadowEffect : RoutingEffect
    {
        public ShadowEffect() : base("MyCompany.LabelShadowEffect")
        {
        }

        public float Radius { get; set; }
        public Color Color { get; set; }
        public float DistanceX { get; set; }
        public float DistanceY { get; set; }
    }
}