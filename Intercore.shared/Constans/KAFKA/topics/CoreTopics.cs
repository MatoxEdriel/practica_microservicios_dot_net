namespace Intercore.shared.CONSTANS.KAFKA.topics;

public static class CoreTopics
{

    public static class Commands
    {
        //Command
        //cmd es uan orden: Algo que se quiera que pase, solo con un destinario
        public const string CreateEmisor = "core.cmd.emisor.create";
        public const string UpdateEmisor = "core.cmd.emisor.update";
        public const string DeleteEmisor = "core.cmd.emisor.delete";
        public const string ChangeEmisorStatus = "core.cmd.emisor.change-status";
        
    }


    public static class Events
    {
         
        //Event
        //evento que algo ya paso, puede tener muchos interesados 
        public const string EmisorCreated = "core.evt.emisor.created";
        public const string EmisorUpdated = "core.evt.emisor.updated";
        public const string EmisorDeleted = "core.evt.emisor.deleted";
        public const string EmisorStatusChanged = "core.evt.emisor.status-changed";
        
        
    }
    
    


    
    
   
    
    

}