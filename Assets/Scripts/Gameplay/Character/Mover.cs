using System;
using UnityEngine;
using Zenject;

namespace Gameplay.Character
{
	public class Mover : MonoBehaviour, IDisposable
	{
		public bool IsMoving => _isMoving;

		[SerializeField] private float _speed = 100f;
		[SerializeField] private Rigidbody2D rb;
		private IInput _input;
		private Vector2 _direction;
		private bool _isMoving;

		[Inject]
		public void Construct(IInput input)
		{
			_input = input;
			_input.OnDirectionChanged += DirectionChangedHandler;
		}

		private void DirectionChangedHandler(Vector2 direction)
		{
			_direction = direction;
			if (_direction == Vector2.zero && _isMoving)
				_isMoving = false;
			else if (_direction != Vector2.zero && !_isMoving)
				_isMoving = true;
		}

		public void FixedUpdate()
		{
			rb.MovePosition(rb.position + _direction * _speed * Time.fixedDeltaTime);
			Debug.Log($"{rb}");
		}

		public void Dispose()
		{
			_input.OnDirectionChanged -= DirectionChangedHandler;
		}
	}
}
