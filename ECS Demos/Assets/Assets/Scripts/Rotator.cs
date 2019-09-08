using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

//Hybrid ECS:

//Entity: this.gameobject

//Component: variables manipulated by system, in Hybrid: Component can be derived from Monobehaviour
public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float m_speed;

    public float Speed
    {
        get
        {
            return m_speed;
        }
    }
}

//System: Using Logic and parameters of Component to work the given task
public class RotatorSystem : ComponentSystem
{
    //To filter which components and Entities are worked on, create struct with specific components held only by one type of entity
    private struct ComponentsDemo1
    {
        private Rotator m_rotator;
        private Transform m_transform;

        public Rotator Rotator
        {
            get
            {
                return m_rotator;
            }
        }

        public Transform Transform
        {
            get
            {
                return m_transform;
            }
        }
    }

    //Using Unity Editor, you can convert GameObjects into Entities
    protected override void OnUpdate()
    {
        float m_deltaTime = Time.deltaTime;

        foreach (ComponentsDemo1 Entity in GetEntities<ComponentsDemo1>())
        {
            Entity.Transform.Rotate(0, Entity.Rotator.Speed*m_deltaTime, 0);
        }
    }
}
