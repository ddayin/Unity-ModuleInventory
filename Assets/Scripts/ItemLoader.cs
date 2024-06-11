using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace InventoryModule
{
    public class ItemLoader : MonoBehaviour
    {
        private Dictionary<string, Sprite> m_DictionarySprites = new Dictionary<string, Sprite>();
        
        public List<Sprite> m_ListArmorSprites = new List<Sprite>();
        public List<Sprite> m_ListWeaponSprites = new List<Sprite>();
        
        private void Awake()
        {
            
        }
        
        public void LoadAllItems()
        {
            m_DictionarySprites.Clear();
            
            // ref : https://docs.unity3d.com/ScriptReference/AssetDatabase.FindAssets.html
            string[] arrayGUID = AssetDatabase.FindAssets("Art/Items");
            
            
        }
        
        public Sprite GetSprite(string _id)
        {
            return m_DictionarySprites[_id];
        }
    }
}