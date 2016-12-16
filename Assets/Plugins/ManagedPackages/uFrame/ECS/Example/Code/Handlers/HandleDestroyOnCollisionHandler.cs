// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSExample {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class HandleDestroyOnCollisionHandler {
        
        public DestroyOnCollision Source;
        
        private uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private int ActionNode12_entityId = default( System.Int32 );
        
        private float ActionNode12_time = default( System.Single );
        
        public uFrame.ECS.UnityUtilities.OnTriggerEnterDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode12_entityId = Source.EntityId;
            // ActionNode
            while (this.DebugInfo("c2f634be-3040-40e8-af07-ccd166b2cb6d","d8bd337f-c92c-44cf-b857-186f17c3eca3", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.DestroyLibrary.DestroyEntity
            uFrame.ECS.Actions.DestroyLibrary.DestroyEntity(ActionNode12_entityId, ActionNode12_time);
            yield break;
        }
    }
}
