using UnityEngine;
using System.Collections.Generic;

namespace Platformer.Mechanics
{
    /// <summary>
    /// This component is used to create a patrol path, two points which enemies will move between.
    /// </summary>
    public partial class PatrolPath : MonoBehaviour
    {
        /// <summary>
        /// One end of the patrol path.
        /// </summary>
        public Vector2 startPosition, endPosition;

        public List<Transform> pathnodes;

        //move towards pathnodes[0];
        //once arrived at pathnodes[0] go to pathnodes[1];

        /// <summary>
        /// Create a Mover instance which is used to move an entity along the path at a certain speed.
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public Mover CreateMover(float speed = 1) => new Mover(this, speed);

        void Reset()
        {
            startPosition = Vector3.left;
            endPosition = Vector3.right;
        }
    }
}