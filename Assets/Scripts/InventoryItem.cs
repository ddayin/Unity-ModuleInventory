using System;
using UnityEngine;
using UnityEngine.UI;

namespace InventoryModule
{
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
    }
}