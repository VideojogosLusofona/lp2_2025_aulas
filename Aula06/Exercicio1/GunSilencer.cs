using System;

namespace Exercicio1
{
    public class GunSilencer : GunDecorator
    {
        private readonly float suppressionPercent;

        public override float NoiseLevel =>
            base.NoiseLevel * (1 - suppressionPercent);

        public GunSilencer(Gun gun, float suppressionPercent)
            : base(gun)
        {
            if (suppressionPercent < 0 || suppressionPercent > 1)
            {
                throw new ArgumentOutOfRangeException(
                    "Invalid suppression!!!!"
                );
            }
            this.suppressionPercent = suppressionPercent;
        }
    }
}
