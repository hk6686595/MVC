using Game.Ctrl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.View
{
    public class StoreWindow : BaseWindow
    {
        public StoreWindow()
        {
            resName = "UI/Window/StoreWindow";
            resident = true;
            selfType = WindowType.StoreWindow;
            scenesType = ScenesType.Login;
        }

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void OnAddListener()
        {
            base.OnAddListener();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
        }

        protected override void OnRemoveListener()
        {
            base.OnRemoveListener();
        }

        protected override void RegisterUIEvent()
        {
            base.RegisterUIEvent();
            foreach (var button in buttonList)
            {
                button.onClick.AddListener(() => OnBuyButtonClick(button.name));
            }
            for (int i = 0; i < buttonList.Length; i++)
            {
                int j = i;
                buttonList[i].onClick.AddListener(() => OnBuyButtonClick(j.ToString()));
            }
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            if (Input.GetKeyDown(KeyCode.C))
            {
                Close();
            }
        }

        private void OnBuyButtonClick(string name)
        {
            Debug.Log($"{name} 点击了!");
            StoreCtrl.Instance.SaveProp(new Prop { id = 1002 });
            var prop = StoreCtrl.Instance.GetProp(1001);
            Debug.Log(prop);
        }
    }
}