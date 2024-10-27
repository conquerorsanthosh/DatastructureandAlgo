
using System.Security.Cryptography;
using static LeetCode.MeetingRooms;
namespace LeetCode
{
	internal class MyMeeting
	{
		public int start;
		public int end;
		public int meetingId;

		public MyMeeting(int id,int s, int e)
		{
			start = s;
			end = e;
			meetingId = id;

		}

	}

	public class MeetingRooms
	{
		
		public int   MostBooked(int n, int[,] meetings)
		{
			bool[] meetingRoom = new bool[n];
			int[] meetingCount = new int[n];

			for (int k = 0; k < n; k++)
			{
				meetingRoom[k] = true;
				meetingCount[k] = 0;
			}



			List<MyMeeting> RemainingmeetingList = new List<MyMeeting>();
			Random random = new Random();
			
			for (int m = 0; m < meetings.GetLength(0); m++)
			{
				MyMeeting current = new MyMeeting(m ,meetings[m, 0], meetings[m, 1]);
				RemainingmeetingList.Add(current);
			}

			//SortedDictionary<int,MyMeeting> meetingBoard= new SortedDictionary<int,MyMeeting>
			Dictionary<int, int> MeetingToRoomMap = new Dictionary<int, int>();

			List<MyMeeting> currentMeetingList = new List<MyMeeting>();

			int currentTime = -1;
			while (true)
			{
				currentTime += 1;
				Console.WriteLine("Current time is " + currentTime);
				if (RemainingmeetingList.Count == 0)
				{
					break;
				}


				MyMeeting meetingToAssign = RemainingmeetingList[0];

				if (currentMeetingList.Count == 0)
				{
					meetingRoom[0] = false;
					currentMeetingList.Add(meetingToAssign);
					MeetingToRoomMap[meetingToAssign.meetingId] = 0;
					Console.WriteLine("meeting room 0 is assigned to " + "meeting id" + meetingToAssign.meetingId);
					RemainingmeetingList.RemoveAt(0);
					Console.WriteLine(meetingToAssign.meetingId + "   meeting id has been removed from the RemainingmeetingList ");
					meetingCount[0]++;

				}

				else
				{
					//check in the map if any of the meeting has compelted.
					for (int p=0;p<currentMeetingList.Count;p++)
					{
						if (currentMeetingList[p].end == currentTime)
						{
							int rId = MeetingToRoomMap[currentMeetingList[p].meetingId];
							Console.WriteLine( currentMeetingList[p].meetingId+"has ended " + rId +"   roomid is available");
							meetingRoom[rId] = true;
							//Console.WriteLine("Removing meeting id" + currentMeetingList[p].meetingId +"from current meeting & meeting map");
							MeetingToRoomMap.Remove(currentMeetingList[p].meetingId);
							currentMeetingList.RemoveAt(p);

						}

					}

					//Assign the meeting to the room
					int roomId = Array.FindIndex(meetingRoom, item => item == true);
									
					if (roomId != -1)
					{
						Console.WriteLine(roomId + "  is available  ");
						meetingRoom[roomId] = false;
						Console.WriteLine(meetingToAssign.meetingId + "   will be assigned   " + roomId);
						MeetingToRoomMap[meetingToAssign.meetingId] = roomId;
						currentMeetingList.Add(meetingToAssign);
						RemainingmeetingList.RemoveAt(0);
						meetingCount[roomId]++;
					}
				}

			}

			Console.WriteLine(Array.IndexOf(meetingCount, meetingCount.Max()) + "Room was used max number of times");

			return Array.IndexOf(meetingCount, meetingCount.Max());
		}
	
	}
}
