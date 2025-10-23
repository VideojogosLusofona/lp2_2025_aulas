namespace Exercicio1Alternative
{
    public interface IGun
    {
        int AmmoCapacity { get; }
        float NoiseLevel { get; }
        void Fire();
    }
}