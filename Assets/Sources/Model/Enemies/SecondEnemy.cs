using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Model
{
    public class SecondEnemy : Enemy
    {
        private readonly Vector2 _direction;
        private readonly float _speed;

        public SecondEnemy(Vector2 position, Vector2 direction, float speed) : base(position, 0)
        {
            _direction = direction;
            _speed = speed;
        }



        public override void Update(float deltaTime)
        {
            MoveTo(Position + _direction * _speed * deltaTime);
        }

        
    }

    
}
