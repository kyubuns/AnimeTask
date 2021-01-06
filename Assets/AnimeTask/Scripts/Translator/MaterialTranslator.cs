using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static MaterialPropertyColorTranslator MaterialPropertyColor(Renderer renderer, int nameID) => new MaterialPropertyColorTranslator(renderer, nameID);
        public static MaterialPropertyColorTranslator MaterialPropertyColor(Renderer renderer, string name) => new MaterialPropertyColorTranslator(renderer, name);
        public static UniTask ToMaterialPropertyColor(this IAnimator<Color> animator, Renderer renderer, int nameID, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, MaterialPropertyColor(renderer, nameID), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyColor(this IAnimator<Color> animator, Renderer renderer, string name, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, MaterialPropertyColor(renderer, name), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyColor(this IAnimatorWithStartValue<Color> animator, Renderer renderer, int nameID, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, MaterialPropertyColor(renderer, nameID), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyColor(this IAnimatorWithStartValue<Color> animator, Renderer renderer, string name, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, MaterialPropertyColor(renderer, name), scheduler, cancellationToken);

        public static MaterialPropertyFloatTranslator MaterialPropertyFloat(Renderer renderer, int nameID) => new MaterialPropertyFloatTranslator(renderer, nameID);
        public static MaterialPropertyFloatTranslator MaterialPropertyFloat(Renderer renderer, string name) => new MaterialPropertyFloatTranslator(renderer, name);
        public static UniTask ToMaterialPropertyFloat(this IAnimator<float> animator, Renderer renderer, int nameID, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, MaterialPropertyFloat(renderer, nameID), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyFloat(this IAnimator<float> animator, Renderer renderer, string name, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, MaterialPropertyFloat(renderer, name), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyFloat(this IAnimatorWithStartValue<float> animator, Renderer renderer, int nameID, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, MaterialPropertyFloat(renderer, nameID), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyFloat(this IAnimatorWithStartValue<float> animator, Renderer renderer, string name, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, MaterialPropertyFloat(renderer, name), scheduler, cancellationToken);

        public static MaterialPropertyIntTranslator MaterialPropertyInt(Renderer renderer, int nameID) => new MaterialPropertyIntTranslator(renderer, nameID);
        public static MaterialPropertyIntTranslator MaterialPropertyInt(Renderer renderer, string name) => new MaterialPropertyIntTranslator(renderer, name);
        public static UniTask ToMaterialPropertyInt(this IAnimator<int> animator, Renderer renderer, int nameID, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, MaterialPropertyInt(renderer, nameID), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyInt(this IAnimator<int> animator, Renderer renderer, string name, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, MaterialPropertyInt(renderer, name), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyInt(this IAnimatorWithStartValue<int> animator, Renderer renderer, int nameID, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, MaterialPropertyInt(renderer, nameID), scheduler, cancellationToken);
        public static UniTask ToMaterialPropertyInt(this IAnimatorWithStartValue<int> animator, Renderer renderer, string name, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, MaterialPropertyInt(renderer, name), scheduler, cancellationToken);
    }

    public class MaterialPropertyColorTranslator : IValueTranslator<Color>
    {
        private readonly Renderer renderer;
        private readonly int nameID;
        private readonly MaterialPropertyBlock materialPropertyBlock;

        public Color Current => materialPropertyBlock.GetColor(nameID);

        public MaterialPropertyColorTranslator(Renderer renderer, int nameID)
        {
            this.renderer = renderer;
            this.nameID = nameID;
            materialPropertyBlock = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(materialPropertyBlock);
        }

        public MaterialPropertyColorTranslator(Renderer renderer, string name)
        {
            this.renderer = renderer;
            nameID = Shader.PropertyToID(name);
            materialPropertyBlock = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(materialPropertyBlock);
        }

        public void Update(Color value)
        {
            materialPropertyBlock.SetColor(nameID, value);
            renderer.SetPropertyBlock(materialPropertyBlock);
        }
    }

    public class MaterialPropertyFloatTranslator : IValueTranslator<float>
    {
        private readonly Renderer renderer;
        private readonly int nameID;
        private readonly MaterialPropertyBlock materialPropertyBlock;

        public float Current => materialPropertyBlock.GetFloat(nameID);

        public MaterialPropertyFloatTranslator(Renderer renderer, int nameID)
        {
            this.renderer = renderer;
            this.nameID = nameID;
            materialPropertyBlock = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(materialPropertyBlock);
        }

        public MaterialPropertyFloatTranslator(Renderer renderer, string name)
        {
            this.renderer = renderer;
            nameID = Shader.PropertyToID(name);
            materialPropertyBlock = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(materialPropertyBlock);
        }

        public void Update(float value)
        {
            materialPropertyBlock.SetFloat(nameID, value);
            renderer.SetPropertyBlock(materialPropertyBlock);
        }
    }

    public class MaterialPropertyIntTranslator : IValueTranslator<int>
    {
        private readonly Renderer renderer;
        private readonly int nameID;
        private readonly MaterialPropertyBlock materialPropertyBlock;

        public int Current => materialPropertyBlock.GetInt(nameID);

        public MaterialPropertyIntTranslator(Renderer renderer, int nameID)
        {
            this.renderer = renderer;
            this.nameID = nameID;
            materialPropertyBlock = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(materialPropertyBlock);
        }

        public MaterialPropertyIntTranslator(Renderer renderer, string name)
        {
            this.renderer = renderer;
            nameID = Shader.PropertyToID(name);
            materialPropertyBlock = new MaterialPropertyBlock();
            renderer.GetPropertyBlock(materialPropertyBlock);
        }

        public void Update(int value)
        {
            materialPropertyBlock.SetInt(nameID, value);
            renderer.SetPropertyBlock(materialPropertyBlock);
        }
    }
}