// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace WorkshopDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class DamageSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Health> _HealthManager;
        
        private IEcsComponentManagerOf<Sword> _SwordManager;
        
        private IEcsComponentManagerOf<Shield> _ShieldManager;
        
        private IEcsComponentManagerOf<Orc> _OrcManager;
        
        public IEcsComponentManagerOf<Health> HealthManager {
            get {
                return _HealthManager;
            }
            set {
                _HealthManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Sword> SwordManager {
            get {
                return _SwordManager;
            }
            set {
                _SwordManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Shield> ShieldManager {
            get {
                return _ShieldManager;
            }
            set {
                _ShieldManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Orc> OrcManager {
            get {
                return _OrcManager;
            }
            set {
                _OrcManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            HealthManager = ComponentSystem.RegisterComponent<Health>(1);
            SwordManager = ComponentSystem.RegisterComponent<Sword>(3);
            ShieldManager = ComponentSystem.RegisterComponent<Shield>(2);
            OrcManager = ComponentSystem.RegisterGroup<OrcGroup,Orc>();
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("e9a23d32-bc34-4a7d-9817-1073825f26cb")]
    public partial class DamageSystem : DamageSystemBase {
        
        private static DamageSystem _Instance;
        
        public DamageSystem() {
            Instance = this;
        }
        
        public static DamageSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}