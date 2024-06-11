using System.Collections.Generic;
using UnityCommunity.UnitySingleton;
using UnityEngine;

namespace InventoryModule
{
    public class ItemLoader : PersistentMonoSingleton<ItemLoader>
    {
        private Dictionary<string, Sprite> m_DictionarySprites = new Dictionary<string, Sprite>();
        
        public List<Sprite> m_ListArmorSprites = new List<Sprite>();
        public List<Sprite> m_ListWeaponSprites = new List<Sprite>();
        
        protected override void Awake()
        {
            base.Awake();
            SetDictionary();
        }
        
        /// <summary>
        /// TODO: 아직 테스트할 것이 많음
        /// </summary>
        public void LoadAllItems()
        {
            m_DictionarySprites.Clear();
            
            // ref : https://docs.unity3d.com/ScriptReference/AssetDatabase.FindAssets.html
            //string[] arrayGUID = AssetDatabase.FindAssets("Art/Items");
        }

        /// <summary>
        /// 테스트 용도, 가장 쉬운 방법으로..
        /// </summary>
        private void SetDictionary()
        {
            foreach (Sprite sprite in m_ListArmorSprites)
            {
                m_DictionarySprites.Add(sprite.name, sprite);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public Sprite GetSprite(string _id)
        {
            if (m_DictionarySprites.TryGetValue(_id, out Sprite sprite) == true)
            {
                return sprite;
            }
            else
            {
                Debug.LogError("Not found sprite with id : " + _id);
                return null;
            }
        }
    }
}