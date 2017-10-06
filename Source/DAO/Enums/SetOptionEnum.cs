﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByVersion DAO 3.6, 12.0
	 /// </summary>
	[SupportByVersion("DAO", 3.6,12.0)]
	[EntityType(EntityType.IsEnum)]
	public enum SetOptionEnum
	{
		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbPageTimeout = 6,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>57</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbLockRetry = 57,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbMaxBufferSize = 8,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>58</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbUserCommitSync = 58,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>59</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbImplicitCommitSync = 59,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>60</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbExclusiveAsyncDelay = 60,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>61</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbSharedAsyncDelay = 61,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>62</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbMaxLocksPerFile = 62,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>63</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbLockDelay = 63,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>65</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbRecycleLVs = 65,

		 /// <summary>
		 /// SupportByVersion DAO 3.6, 12.0
		 /// </summary>
		 /// <remarks>66</remarks>
		 [SupportByVersion("DAO", 3.6,12.0)]
		 dbFlushTransactionTimeout = 66,

		 /// <summary>
		 /// SupportByVersion DAO 12.0
		 /// </summary>
		 /// <remarks>80</remarks>
		 [SupportByVersion("DAO", 12.0)]
		 dbPasswordEncryptionProvider = 80,

		 /// <summary>
		 /// SupportByVersion DAO 12.0
		 /// </summary>
		 /// <remarks>81</remarks>
		 [SupportByVersion("DAO", 12.0)]
		 dbPasswordEncryptionAlgorithm = 81,

		 /// <summary>
		 /// SupportByVersion DAO 12.0
		 /// </summary>
		 /// <remarks>82</remarks>
		 [SupportByVersion("DAO", 12.0)]
		 dbPasswordEncryptionKeyLength = 82
	}
}