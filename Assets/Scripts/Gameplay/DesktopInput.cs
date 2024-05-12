using System;
using UnityEngine;

namespace Gameplay
{
	public class DesktopInput : MonoBehaviour, IInput
	{
		public event Action<Vector2> OnDirectionChanged;

		private float _lastHorizontal, _lastVertical;
		private float _currentHorizontal, _currentVertical;
		private bool _isDirectionChanged;
		private Vector2 _direction;

		private void Update()
		{
			_currentHorizontal = Input.GetAxis("Horizontal");
			_currentVertical = Input.GetAxis("Vertical");

			_isDirectionChanged = (_lastHorizontal != _currentHorizontal) || (_lastVertical != _currentVertical);
			
			_lastHorizontal = _currentHorizontal;
			_lastVertical = _currentVertical;

			if (_isDirectionChanged)
			{
				_direction.x = _lastHorizontal;
				_direction.y = _lastVertical;
				OnDirectionChanged?.Invoke(_direction);
			}
		}
	}
}
