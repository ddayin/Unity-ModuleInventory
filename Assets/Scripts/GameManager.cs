using System;
using UnityCommunity.UnitySingleton;
using UnityEngine;

namespace InventoryModule
{
    public class GameManager : PersistentMonoSingleton<GameManager>
    {
        private InventoryContainer m_InventoryContainer;

        protected override void Awake()
        {
            base.Awake();
        }
    }
}