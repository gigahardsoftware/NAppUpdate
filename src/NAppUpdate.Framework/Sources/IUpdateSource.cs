using System;
using NAppUpdate.Framework.Common;
using System.ServiceModel;

namespace NAppUpdate.Framework.Sources
{
	[ServiceContract]
	public interface IUpdateSource
	{
		[OperationContract]
		string GetUpdatesFeed(); // TODO: return a the feed as a stream

		[OperationContract]
		bool GetData(string filePath, string basePath, Action<UpdateProgressInfo> onProgress, ref string tempLocation);
	}
}
