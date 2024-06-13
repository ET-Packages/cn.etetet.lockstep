﻿using System;
using UnityEngine;

namespace ET.Client
{
    [UIEvent(UIType.UILSLogin)]
    public class UILSLoginEvent: AUIEvent
    {
        public override async ETTask<UI> OnCreate(UIComponent uiComponent, UILayer uiLayer)
        {
            string assetsName = $"Packages/cn.etetet.lockstep/Bundles/UI/{UIType.UILSLogin}.prefab";

            if (uiComponent.Scene().GetComponent<ResourcesLoaderComponent>() == null)
            {
                Log.Debug($"111111111111111111111111111111111111111");
            }
            
            GameObject bundleGameObject = await uiComponent.Scene().GetComponent<ResourcesLoaderComponent>().LoadAssetAsync<GameObject>(assetsName);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject, uiComponent.UIGlobalComponent.GetLayer((int)uiLayer));
            UI ui = uiComponent.AddChild<UI, string, GameObject>(UIType.UILSLogin, gameObject);
            ui.AddComponent<UILSLoginComponent>();
            return ui;
        }

        public override void OnRemove(UIComponent uiComponent)
        {
        }
    }
}