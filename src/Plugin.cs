using System;
using BepInEx;
using UnityEngine;
using SlugBase.Features;
using static SlugBase.Features.FeatureTypes;

namespace Sam
{
    [BepInPlugin(MOD_ID, "Sam", "1")]
    class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "mszegedy.sam";

        // Add hooks
        public void OnEnable()
        {
            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);
        }

        // Load any resources, such as sprites or sounds
        private void LoadResources(RainWorld rainWorld)
        {
            Futile.atlasManager.LoadAtlas("atlases/EXtemplatearm");
            Futile.atlasManager.LoadAtlas("atlases/EXtemplatebody");
            Futile.atlasManager.LoadAtlas("atlases/EXtemplateears");
            Futile.atlasManager.LoadAtlas("atlases/EXtemplateface");
            Futile.atlasManager.LoadAtlas("atlases/EXtemplatehead");
            Futile.atlasManager.LoadAtlas("atlases/EXtemplatehips");
            Futile.atlasManager.LoadAtlas("atlases/EXtemplatelegs");
        }
    }
}
