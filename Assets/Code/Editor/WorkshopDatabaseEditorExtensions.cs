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
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    [UnityEditor.InitializeOnLoadAttribute()]
    [uFrame.Attributes.uFrameIdentifier("265a0475-8b4b-40ce-9ad3-96f63f73b857")]
    public class WorkshopDatabaseEditorExtensions {
        
        [UnityEditor.MenuItem("GameObject/Create WorkshopDatabase Kernel", false, 0)]
        public static void AddKernel() {
            uFrame.ECS.Templates.EcsEditorExtensionTemplate.AddEcsKernelWith<WorkshopDB.WorkshopDatabaseLoader>();
        }
    }
}