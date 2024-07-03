using System;
using Enums;
using HexViewScripts;
using UnityEngine;

namespace FrogScripts
{
    /// <summary>
    /// Represents a frog element on the hex grid, managing its properties and actions.
    /// </summary>
    public class Frog : HexViewElement
    {
        [SerializeField]
        private FrogData _properties;
        
        /// <summary>
        /// Gets or sets the direction of the frog.
        /// </summary>
        public Direction FrogDirection { get; private set; }

        public override void SetDirection(Direction direction)
        {
            FrogDirection = direction;
            var rotation = new Vector3(0, 0, GetZDirection(direction));
            
            transform.rotation=Quaternion.Euler(rotation);
        }

        private float GetZDirection(Direction direction)
        {
            return direction switch
            {
                Direction.Down or Direction.None => 0,
                Direction.Up => 180,
                Direction.DownLeft => -53f,
                Direction.DownRight => 53f,
                Direction.UpLeft => -110f,
                Direction.UpRight => 110f,
                _ => 0f
            };
        }

        /// <summary>
        /// Executes the action associated with the frog.
        /// </summary>
        public override void OnAction()
        {
            // Action logic for the frog
        }

        public override void SetColor(ColorType colorType)
        {
            _properties.SetFrogColor(colorType);
        }

        private void OnMouseDown()
        {
            Debug.Log("ÇAÇA "+gameObject.name);
        }
    }
}
