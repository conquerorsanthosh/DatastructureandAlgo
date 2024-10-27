public class Solution 
{
    public class MeetingRoom
    {
        int roomId;
        int numberOfMeeting;
        bool isOccupied;          

        public MeetingRoom(int id)
        {
            roomId=id;
            numberOfMeeting=0;
            isOccupied=false;          

        }
            
   }
    
   public int GetAvailableRoom(List<MeetingRooms> meetingRooms)
   {
       
       
   } 
        

    
    public int MostBooked(int n, int[][] meetings) 
    {
        /*
        
         1. what is the  next meeting
         2. what is the next available room
         3. Current time
        
        */
        
        //Create MeetingRooms
        List<MeetingRoom> meetingRooms =new List<MeetingRoom>();
        
        for(int i=0;i<n;i++)
        {
            MeetingRooms.Add(new MeetingRoom(i));
            
        }
                          
        Dictionary<int,int> roomToMeetingMap = new Dictionary<int,int>();
        
        int remaningMeeting=meetingRooms.Length;
        while(remaningMeeting>0)
        {
            if(GetAvailableRoom(meetingRooms)!=-1)
            {
                
                
                
            }
            
               
        }
        
    }
}public class Solution 
{
    public class MeetingRoom
    {
        int roomId;
        int numberOfMeeting;
        bool isOccupied;          

        public MeetingRoom(int id)
        {
            roomId=id;
            numberOfMeeting=0;
            isOccupied=false;          

        }
            
   }
    
   public int GetAvailableRoom(List<MeetingRooms> meetingRooms)
   {
       
       
   } 
        

    
    public int MostBooked(int n, int[][] meetings) 
    {
        /*
        
         1. what is the  next meeting
         2. what is the next available room
         3. Current time
        
        */
        
        //Create MeetingRooms
        List<MeetingRoom> meetingRooms =new List<MeetingRoom>();
        
        for(int i=0;i<n;i++)
        {
            MeetingRooms.Add(new MeetingRoom(i));
            
        }
                          
        Dictionary<int,int> roomToMeetingMap = new Dictionary<int,int>();
        
        int remaningMeeting=meetingRooms.Length;
        while(remaningMeeting>0)
        {
            if(GetAvailableRoom(meetingRooms)!=-1)
            {
                
                
                
            }
            
               
        }
        
    }
}