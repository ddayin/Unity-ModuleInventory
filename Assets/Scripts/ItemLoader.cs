using System;
using UnityEditor;
using UnityEngine;

namespace InventoryModule
{
    public class ItemLoader : MonoBehaviour
    {
        public SerializableDictionary<string, Sprite>
            m_DictionarySprites = new SerializableDictionary<string, Sprite>();
        
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