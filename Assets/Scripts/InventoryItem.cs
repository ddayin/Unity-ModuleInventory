using System;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryModule
{
    [Serializable]
    public class ItemModel
    {
        public string guid;
        public string imageName;
        public string category;
        public string description;  // temp
    }
    
    [RequireComponent(typeof(Image))]
    public class InventoryItem : MonoBehaviour
    {
        private Image m_Icon;

        private void Awake()
        {
            m_Icon = GetComponent<Image>();
        }

        private void OnMouseOver()
        {
            
        }

        private void OnMouseExit()
        {
            
        }

        public void SetIcon(Sprite _icon)
        {
            m_Icon.sprite = _icon;
        }

        public void SetIcon(string _guid)
        {
            m_Icon.sprite = ItemLoader.Instance.GetSprite(_guid);
        }
    }
}