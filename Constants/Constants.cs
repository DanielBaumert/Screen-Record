namespace ToolKitRAT.WinApi.Constants {
    class Constants {
        public const int SRCCOPY = 0xCC0020;

    }
    
    public enum Error {
        #region 0 - 499

        /// <summary>
        /// The operation completed successfully.
        /// </summary>
        ERROR_SUCCESS = 0x0,
        /// <summary>
        /// Incorrect function.
        /// </summary>
        ERROR_INVALID_FUNCTION = 0x1,
        /// <summary>
        /// The system cannot find the file specified.
        /// </summary>
        ERROR_FILE_NOT_FOUND = 0x2,
        /// <summary>
        /// The system cannot find the path specified.
        /// </summary>
        ERROR_PATH_NOT_FOUND = 0x3,
        /// <summary>
        /// The system cannot open the file.
        /// </summary>
        ERROR_TOO_MANY_OPEN_FILES = 0x4,
        /// <summary>
        /// Access is denied.
        /// </summary>
        ERROR_ACCESS_DENIED = 0x5,
        /// <summary>
        /// The handle is invalid.
        /// </summary>
        ERROR_INVALID_HANDLE = 0x6,
        /// <summary>
        /// The storage control blocks were destroyed.
        /// </summary>
        ERROR_ARENA_TRASHED = 0x7,
        /// <summary>
        /// Not enough storage is available to process this command.
        /// </summary>
        ERROR_NOT_ENOUGH_MEMORY = 0x8,
        /// <summary>
        /// The storage control block address is invalid.
        /// </summary>
        ERROR_INVALID_BLOCK = 0x9,
        /// <summary>
        /// The environment is incorrect.
        /// </summary>
        ERROR_BAD_ENVIRONMENT = 0xA,
        /// <summary>
        /// An attempt was made to load a program with an incorrect format.
        /// </summary>
        ERROR_BAD_FORMAT = 0xB,
        /// <summary>
        /// The access code is invalid.
        /// </summary>
        ERROR_INVALID_ACCESS = 0xC,
        /// <summary>
        /// The data is invalid.
        /// </summary>
        ERROR_INVALID_DATA = 0xD,
        /// <summary>
        /// Not enough storage is available to complete this operation.
        /// </summary>
        ERROR_OUTOFMEMORY = 0xE,
        /// <summary>
        /// The system cannot find the drive specified.
        /// </summary>
        ERROR_INVALID_DRIVE = 0xF,
        /// <summary>
        /// The directory cannot be removed.
        /// </summary>
        ERROR_CURRENT_DIRECTORY = 0x10,
        /// <summary>
        /// The system cannot move the file to a different disk drive.
        /// </summary>
        ERROR_NOT_SAME_DEVICE = 0x11,
        /// <summary>
        /// There are no more files.
        /// </summary>
        ERROR_NO_MORE_FILES = 0x12,
        /// <summary>
        /// The media is write protected.
        /// </summary>
        ERROR_WRITE_PROTECT = 0x13,
        /// <summary>
        /// The system cannot find the device specified.
        /// </summary>
        ERROR_BAD_UNIT = 0x14,
        /// <summary>
        /// The device is not ready.
        /// </summary>
        ERROR_NOT_READY = 0x15,
        /// <summary>
        /// The device does not recognize the command.
        /// </summary>
        ERROR_BAD_COMMAND = 0x16,
        /// <summary>
        /// Data error (cyclic redundancy check).
        /// </summary>
        ERROR_CRC = 0x17,
        /// <summary>
        /// The program issued a command but the command length is incorrect.
        /// </summary>
        ERROR_BAD_LENGTH = 0x18,
        /// <summary>
        /// The drive cannot locate a specific area or track on the disk.
        /// </summary>
        ERROR_SEEK = 0x19,
        /// <summary>
        /// The specified disk or diskette cannot be accessed.
        /// </summary>
        ERROR_NOT_DOS_DISK = 0x1A,
        /// <summary>
        /// The drive cannot find the sector requested.
        /// </summary>
        ERROR_SECTOR_NOT_FOUND = 0x1B,
        /// <summary>
        /// The printer is out of paper.
        /// </summary>
        ERROR_OUT_OF_PAPER = 0x1C,
        /// <summary>
        /// The system cannot write to the specified device.
        /// </summary>
        ERROR_WRITE_FAULT = 0x1D,
        /// <summary>
        /// The system cannot read from the specified device.
        /// </summary>
        ERROR_READ_FAULT = 0x1E,
        /// <summary>
        /// A device attached to the system is not functioning.
        /// </summary>
        ERROR_GEN_FAILURE = 0x1F,
        /// <summary>
        /// The process cannot access the file because it is being used by another process.
        /// </summary>
        ERROR_SHARING_VIOLATION = 0x20,
        /// <summary>
        /// The process cannot access the file because another process has locked a portion of the file.
        /// </summary>
        ERROR_LOCK_VIOLATION = 0x21,
        /// <summary>
        /// The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into drive %1.
        /// </summary>
        ERROR_WRONG_DISK = 0x22,
        /// <summary>
        /// Too many files opened for sharing.
        /// </summary>
        ERROR_SHARING_BUFFER_EXCEEDED = 0x24,
        /// <summary>
        /// Reached the end of the file.
        /// </summary>
        ERROR_HANDLE_EOF = 0x26,
        /// <summary>
        /// The disk is full.
        /// </summary>
        ERROR_HANDLE_DISK_FULL = 0x27,
        /// <summary>
        /// The request is not supported.
        /// </summary>
        ERROR_NOT_SUPPORTED = 0x32,
        /// <summary>
        /// Windows cannot find the network path. Verify that the network path is correct and the destination computer 
        /// is not busy or turned off. If Windows still cannot find the network path, contact your network
        /// administrator.
        /// </summary>
        ERROR_REM_NOT_LIST = 0x33,
        /// <summary>
        /// You were not connected because a duplicate name exists on the network. If joining a domain, go to System in 
        /// Control Panel to change the computer name and try again. If joining a workgroup, choose another workgroup name.
        /// </summary>
        ERROR_DUP_NAME = 0x34,
        /// <summary>
        /// The network path was not found.
        /// </summary>
        ERROR_BAD_NETPATH = 0x35,
        /// <summary>
        /// The network is busy.
        /// </summary>
        ERROR_NETWORK_BUSY = 0x36,
        /// <summary>
        /// The specified network resource or device is no longer available.
        /// </summary>
        ERROR_DEV_NOT_EXIST = 0x37,
        /// <summary>
        /// The network BIOS command limit has been reached.
        /// </summary>
        ERROR_TOO_MANY_CMDS = 0x38,
        /// <summary>
        /// A network adapter hardware error occurred.
        /// </summary>
        ERROR_ADAP_HDW_ERR = 0x39,
        /// <summary>
        /// The specified server cannot perform the requested operation.
        /// </summary>
        ERROR_BAD_NET_RESP = 0x3A,
        /// <summary>
        /// An unexpected network error occurred.
        /// </summary>
        ERROR_UNEXP_NET_ERR = 0x3B,
        /// <summary>
        /// The remote adapter is not compatible.
        /// </summary>
        ERROR_BAD_REM_ADAP = 0x3C,
        /// <summary>
        /// The printer queue is full.
        /// </summary>
        ERROR_PRINTQ_FULL = 0x3D,
        /// <summary>
        /// Space to store the file waiting to be printed is not available on the server.
        /// </summary>
        ERROR_NO_SPOOL_SPACE = 0x3E,
        /// <summary>
        /// Your file waiting to be printed was deleted.
        /// </summary>
        ERROR_PRINT_CANCELLED = 0x3F,
        /// <summary>
        /// The specified network name is no longer available.
        /// </summary>
        ERROR_NETNAME_DELETED = 0x40,
        /// <summary>
        /// Network access is denied.
        /// </summary>
        ERROR_NETWORK_ACCESS_DENIED = 0x41,
        /// <summary>
        /// The network resource type is not correct.
        /// </summary>
        ERROR_BAD_DEV_TYPE = 0x42,
        /// <summary>
        /// The network name cannot be found.
        /// </summary>
        ERROR_BAD_NET_NAME = 0x43,
        /// <summary>
        /// The name limit for the local computer network adapter card was exceeded.
        /// </summary>
        ERROR_TOO_MANY_NAMES = 0x44,
        /// <summary>
        /// The network BIOS session limit was exceeded.
        /// </summary>
        ERROR_TOO_MANY_SESS = 0x45,
        /// <summary>
        /// The remote server has been paused or is in the process of being started.
        /// </summary>
        ERROR_SHARING_PAUSED = 0x46,
        /// <summary>
        /// No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.
        /// </summary>
        ERROR_REQ_NOT_ACCEP = 0x47,
        /// <summary>
        /// The specified printer or disk device has been paused.
        /// </summary>
        ERROR_REDIR_PAUSED = 0x48,
        /// <summary>
        /// The file exists.
        /// </summary>
        ERROR_FILE_EXISTS = 0x50,
        /// <summary>
        /// The directory or file cannot be created.
        /// </summary>
        ERROR_CANNOT_MAKE = 0x52,
        /// <summary>
        /// Fail on INT 24.
        /// </summary>
        ERROR_FAIL_I24 = 0x53,
        /// <summary>
        /// Storage to process this request is not available.
        /// </summary>
        ERROR_OUT_OF_STRUCTURES = 0x54,
        /// <summary>
        /// The local device name is already in use.
        /// </summary>
        ERROR_ALREADY_ASSIGNED = 0x55,
        /// <summary>
        /// The specified network password is not correct.
        /// </summary>
        ERROR_INVALID_PASSWORD = 0x56,
        /// <summary>
        /// The parameter is incorrect.
        /// </summary>
        ERROR_INVALID_PARAMETER = 0x57,
        /// <summary>
        /// A write fault occurred on the network.
        /// </summary>
        ERROR_NET_WRITE_FAULT = 0x58,
        /// <summary>
        /// The system cannot start another process at this time.
        /// </summary>
        ERROR_NO_PROC_SLOTS = 0x59,
        /// <summary>
        /// Cannot create another system semaphore.
        /// </summary>
        ERROR_TOO_MANY_SEMAPHORES = 0x64,
        /// <summary>
        /// The exclusive semaphore is owned by another process.
        /// </summary>
        ERROR_EXCL_SEM_ALREADY_OWNED = 0x65,
        /// <summary>
        /// The semaphore is set and cannot be closed.
        /// </summary>
        ERROR_SEM_IS_SET = 0x66,
        /// <summary>
        /// The semaphore cannot be set again.
        /// </summary>
        ERROR_TOO_MANY_SEM_REQUESTS = 0x67,
        /// <summary>
        /// Cannot request exclusive semaphores at interrupt time.
        /// </summary>
        ERROR_INVALID_AT_INTERRUPT_TIME = 0x68,
        /// <summary>
        /// The previous ownership of this semaphore has ended.
        /// </summary>
        ERROR_SEM_OWNER_DIED = 0x69,
        /// <summary>
        /// Insert the diskette for drive %1.
        /// </summary>
        ERROR_SEM_USER_LIMIT = 0x6A,
        /// <summary>
        /// The program stopped because an alternate diskette was not inserted.
        /// </summary>
        ERROR_DISK_CHANGE = 0x6B,
        /// <summary>
        /// The disk is in use or locked by another process.
        /// </summary>
        ERROR_DRIVE_LOCKED = 0x6C,
        /// <summary>
        /// The pipe has been ended.
        /// </summary>
        ERROR_BROKEN_PIPE = 0x6D,
        /// <summary>
        /// The system cannot open the device or file specified.
        /// </summary>
        ERROR_OPEN_FAILED = 0x6E,
        /// <summary>
        /// The file name is too long.
        /// </summary>
        ERROR_BUFFER_OVERFLOW = 0x6F,
        /// <summary>
        /// There is not enough space on the disk.
        /// </summary>
        ERROR_DISK_FULL = 0x70,
        /// <summary>
        /// No more internal file identifiers available.
        /// </summary>
        ERROR_NO_MORE_SEARCH_HANDLES = 0x71,
        /// <summary>
        /// The target internal file identifier is incorrect.
        /// </summary>
        ERROR_INVALID_TARGET_HANDLE = 0x72,
        /// <summary>
        /// The IOCTL call made by the application program is not correct.
        /// </summary>
        ERROR_INVALID_CATEGORY = 0x75,
        /// <summary>
        /// The verify-on-write switch parameter value is not correct.
        /// </summary>
        ERROR_INVALID_VERIFY_SWITCH = 0x76,
        /// <summary>
        /// The system does not support the command requested.
        /// </summary>
        ERROR_BAD_DRIVER_LEVEL = 0x77,
        /// <summary>
        /// This function is not supported on this system.
        /// </summary>
        ERROR_CALL_NOT_IMPLEMENTED = 0x78,
        /// <summary>
        /// The semaphore timeout period has expired.
        /// </summary>
        ERROR_SEM_TIMEOUT = 0x79,
        /// <summary>
        /// The data area passed to a system call is too small.
        /// </summary>
        ERROR_INSUFFICIENT_BUFFER = 0x7A,
        /// <summary>
        /// The filename, directory name, or volume label syntax is incorrect.
        /// </summary>
        ERROR_INVALID_NAME = 0x7B,
        /// <summary>
        /// The system call level is not correct.
        /// </summary>
        ERROR_INVALID_LEVEL = 0x7C,
        /// <summary>
        /// The disk has no volume label.
        /// </summary>
        ERROR_NO_VOLUME_LABEL = 0x7D,
        /// <summary>
        /// The specified module could not be found.
        /// </summary>
        ERROR_MOD_NOT_FOUND = 0x7E,
        /// <summary>
        /// The specified procedure could not be found.
        /// </summary>
        ERROR_PROC_NOT_FOUND = 0x7F,
        /// <summary>
        /// There are no child processes to wait for.
        /// </summary>
        ERROR_WAIT_NO_CHILDREN = 0x80,
        /// <summary>
        /// The %1 application cannot be run in Win32 mode.
        /// </summary>
        ERROR_CHILD_NOT_COMPLETE = 0x81,
        /// <summary>
        /// Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.
        /// </summary>
        ERROR_DIRECT_ACCESS_HANDLE = 0x82,
        /// <summary>
        /// An attempt was made to move the file pointer before the beginning of the file.
        /// </summary>
        ERROR_NEGATIVE_SEEK = 0x83,
        /// <summary>
        /// The file pointer cannot be set on the specified device or file.
        /// </summary>
        ERROR_SEEK_ON_DEVICE = 0x84,
        /// <summary>
        /// A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.
        /// </summary>
        ERROR_IS_JOIN_TARGET = 0x85,
        /// <summary>
        /// An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.
        /// </summary>
        ERROR_IS_JOINED = 0x86,
        /// <summary>
        /// An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.
        /// </summary>
        ERROR_IS_SUBSTED = 0x87,
        /// <summary>
        /// The system tried to delete the JOIN of a drive that is not joined.
        /// </summary>
        ERROR_NOT_JOINED = 0x88,
        /// <summary>
        /// The system tried to delete the substitution of a drive that is not substituted.
        /// </summary>
        ERROR_NOT_SUBSTED = 0x89,
        /// <summary>
        /// The system tried to join a drive to a directory on a joined drive.
        /// </summary>
        ERROR_JOIN_TO_JOIN = 0x8A,
        /// <summary>
        /// The system tried to substitute a drive to a directory on a substituted drive.
        /// </summary>
        ERROR_SUBST_TO_SUBST = 0x8B,
        /// <summary>
        /// The system tried to join a drive to a directory on a substituted drive.
        /// </summary>
        ERROR_JOIN_TO_SUBST = 0x8C,
        /// <summary>
        /// The system tried to SUBST a drive to a directory on a joined drive.
        /// </summary>
        ERROR_SUBST_TO_JOIN = 0x8D,
        /// <summary>
        /// The system cannot perform a JOIN or SUBST at this time.
        /// </summary>
        ERROR_BUSY_DRIVE = 0x8E,
        /// <summary>
        /// The system cannot join or substitute a drive to or for a directory on the same drive.
        /// </summary>
        ERROR_SAME_DRIVE = 0x8F,
        /// <summary>
        /// The directory is not a subdirectory of the root directory.
        /// </summary>
        ERROR_DIR_NOT_ROOT = 0x90,
        /// <summary>
        /// The directory is not empty.
        /// </summary>
        ERROR_DIR_NOT_EMPTY = 0x91,
        /// <summary>
        /// The path specified is being used in a substitute.
        /// </summary>
        ERROR_IS_SUBST_PATH = 0x92,
        /// <summary>
        /// Not enough resources are available to process this command.
        /// </summary>
        ERROR_IS_JOIN_PATH = 0x93,
        /// <summary>
        /// The path specified cannot be used at this time.
        /// </summary>
        ERROR_PATH_BUSY = 0x94,
        /// <summary>
        /// An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.
        /// </summary>
        ERROR_IS_SUBST_TARGET = 0x95,
        /// <summary>
        /// System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.
        /// </summary>
        ERROR_SYSTEM_TRACE = 0x96,
        /// <summary>
        /// The number of specified semaphore events for DosMuxSemWait is not correct.
        /// </summary>
        ERROR_INVALID_EVENT_COUNT = 0x97,
        /// <summary>
        /// DosMuxSemWait did not execute; too many semaphores are already set.
        /// </summary>
        ERROR_TOO_MANY_MUXWAITERS = 0x98,
        /// <summary>
        /// The DosMuxSemWait list is not correct.
        /// </summary>
        ERROR_INVALID_LIST_FORMAT = 0x99,
        /// <summary>
        /// The volume label you entered exceeds the label character limit of the target file system.
        /// </summary>
        ERROR_LABEL_TOO_LONG = 0x9A,
        /// <summary>
        /// Cannot create another thread.
        /// </summary>
        ERROR_TOO_MANY_TCBS = 0x9B,
        /// <summary>
        /// The recipient process has refused the signal.
        /// </summary>
        ERROR_SIGNAL_REFUSED = 0x9C,
        /// <summary>
        /// The segment is already discarded and cannot be locked.
        /// </summary>
        ERROR_DISCARDED = 0x9D,
        /// <summary>
        /// The segment is already unlocked.
        /// </summary>
        ERROR_NOT_LOCKED = 0x9E,
        /// <summary>
        /// The address for the thread ID is not correct.
        /// </summary>
        ERROR_BAD_THREADID_ADDR = 0x9F,
        /// <summary>
        /// One or more arguments are not correct.
        /// </summary>
        ERROR_BAD_ARGUMENTS = 0xA0,
        /// <summary>
        /// The specified path is invalid.
        /// </summary>
        ERROR_BAD_PATHNAME = 0xA1,
        /// <summary>
        /// A signal is already pending.
        /// </summary>
        ERROR_SIGNAL_PENDING = 0xA2,
        /// <summary>
        /// No more threads can be created in the system.
        /// </summary>
        ERROR_MAX_THRDS_REACHED = 0xA4,
        /// <summary>
        /// Unable to lock a region of a file.
        /// </summary>
        ERROR_LOCK_FAILED = 0xA7,
        /// <summary>
        /// The requested resource is in use.
        /// </summary>
        ERROR_BUSY = 0xAA,
        /// <summary>
        /// Device's command support detection is in progress.
        /// </summary>
        ERROR_DEVICE_SUPPORT_IN_PROGRESS = 0xAB,
        /// <summary>
        /// A lock request was not outstanding for the supplied cancel region.
        /// </summary>
        ERROR_CANCEL_VIOLATION = 0xAD,
        /// <summary>
        /// The file system does not support atomic changes to the lock type.
        /// </summary>
        ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 0xAE,
        /// <summary>
        /// The system detected a segment number that was not correct.
        /// </summary>
        ERROR_INVALID_SEGMENT_NUMBER = 0xB4,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_ORDINAL = 0xB6,
        /// <summary>
        /// Cannot create a file when that file already exists.
        /// </summary>
        ERROR_ALREADY_EXISTS = 0xB7,
        /// <summary>
        /// The flag passed is not correct.
        /// </summary>
        ERROR_INVALID_FLAG_NUMBER = 0xBA,
        /// <summary>
        /// The specified system semaphore name was not found.
        /// </summary>
        ERROR_SEM_NOT_FOUND = 0xBB,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_STARTING_CODESEG = 0xBC,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_STACKSEG = 0xBD,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_MODULETYPE = 0xBE,
        /// <summary>
        /// Cannot run %1 in Win32 mode.
        /// </summary>
        ERROR_INVALID_EXE_SIGNATURE = 0xBF,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_EXE_MARKED_INVALID = 0xC0,
        /// <summary>
        /// %1 is not a valid Win32 application.
        /// </summary>
        ERROR_BAD_EXE_FORMAT = 0xC1,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_ITERATED_DATA_EXCEEDS_64k = 0xC2,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_MINALLOCSIZE = 0xC3,
        /// <summary>
        /// The operating system cannot run this application program.
        /// </summary>
        ERROR_DYNLINK_FROM_INVALID_RING = 0xC4,
        /// <summary>
        /// The operating system is not presently configured to run this application.
        /// </summary>
        ERROR_IOPL_NOT_ENABLED = 0xC5,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INVALID_SEGDPL = 0xC6,
        /// <summary>
        /// The operating system cannot run this application program.
        /// </summary>
        ERROR_AUTODATASEG_EXCEEDS_64k = 0xC7,
        /// <summary>
        /// The code segment cannot be greater than or equal to 64K.
        /// </summary>
        ERROR_RING2SEG_MUST_BE_MOVABLE = 0xC8,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 0xC9,
        /// <summary>
        /// The operating system cannot run %1.
        /// </summary>
        ERROR_INFLOOP_IN_RELOC_CHAIN = 0xCA,
        /// <summary>
        /// The system could not find the environment option that was entered.
        /// </summary>
        ERROR_ENVVAR_NOT_FOUND = 0xCB,
        /// <summary>
        /// No process in the command subtree has a signal handler.
        /// </summary>
        ERROR_NO_SIGNAL_SENT = 0xCD,
        /// <summary>
        /// The filename or extension is too long.
        /// </summary>
        ERROR_FILENAME_EXCED_RANGE = 0xCE,
        /// <summary>
        /// The ring 2 stack is in use.
        /// </summary>
        ERROR_RING2_STACK_IN_USE = 0xCF,
        /// <summary>
        /// The global filename characters, * or ?, are entered incorrectly or too many global filename characters are 
        /// specified.
        /// </summary>
        ERROR_META_EXPANSION_TOO_LONG = 0xD0,
        /// <summary>
        /// The signal being posted is not correct.
        /// </summary>
        ERROR_INVALID_SIGNAL_NUMBER = 0xD1,
        /// <summary>
        /// The signal handler cannot be set.
        /// </summary>
        ERROR_THREAD_1_INACTIVE = 0xD2,
        /// <summary>
        /// The segment is locked and cannot be reallocated.
        /// </summary>
        ERROR_LOCKED = 0xD4,
        /// <summary>
        /// Too many dynamic-link modules are attached to this program or dynamic-link module.
        /// </summary>
        ERROR_TOO_MANY_MODULES = 0xD6,
        /// <summary>
        /// Cannot nest calls to LoadModule.
        /// </summary>
        ERROR_NESTING_NOT_ALLOWED = 0xD7,
        /// <summary>
        /// This version of %1 is not compatible with the version of Windows you're running. Check your computer's 
        /// system information and then
        /// contact the software publisher.
        /// </summary>
        ERROR_EXE_MACHINE_TYPE_MISMATCH = 0xD8,
        /// <summary>
        /// The image file %1 is signed, unable to modify.
        /// </summary>
        ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 0xD9,
        /// <summary>
        /// The image file %1 is strong signed, unable to modify.
        /// </summary>
        ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 0xDA,
        /// <summary>
        /// This file is checked out or locked for editing by another user.
        /// </summary>
        ERROR_FILE_CHECKED_OUT = 0xDC,
        /// <summary>
        /// The file must be checked out before saving changes.
        /// </summary>
        ERROR_CHECKOUT_REQUIRED = 0xDD,
        /// <summary>
        /// The file type being saved or retrieved has been blocked.
        /// </summary>
        ERROR_BAD_FILE_TYPE = 0xDE,
        /// <summary>
        /// The file size exceeds the limit allowed and cannot be saved.
        /// </summary>
        ERROR_FILE_TOO_LARGE = 0xDF,
        /// <summary>
        /// Access Denied. Before opening files in this location, you must first add the web site to your trusted sites 
        /// list, browse to the web site, and select the option to login automatically.
        /// </summary>
        ERROR_FORMS_AUTH_REQUIRED = 0xE0,
        /// <summary>
        /// Operation did not complete successfully because the file contains a virus or potentially unwanted 
        /// software.
        /// </summary>
        ERROR_VIRUS_INFECTED = 0xE1,
        /// <summary>
        /// This file contains a virus or potentially unwanted software and cannot be opened. Due to the nature of this 
        /// virus or potentially unwanted software, the file has been removed from this location.
        /// </summary>
        ERROR_VIRUS_DELETED = 0xE2,
        /// <summary>
        /// The pipe is local.
        /// </summary>
        ERROR_PIPE_LOCAL = 0xE5,
        /// <summary>
        /// The pipe state is invalid.
        /// </summary>
        ERROR_BAD_PIPE = 0xE6,
        /// <summary>
        /// All pipe instances are busy.
        /// </summary>
        ERROR_PIPE_BUSY = 0xE7,
        /// <summary>
        /// The pipe is being closed.
        /// </summary>
        ERROR_NO_DATA = 0xE8,
        /// <summary>
        /// No process is on the other end of the pipe.
        /// </summary>
        ERROR_PIPE_NOT_CONNECTED = 0xE9,
        /// <summary>
        /// More data is available.
        /// </summary>
        ERROR_MORE_DATA = 0xEA,
        /// <summary>
        /// The session was canceled.
        /// </summary>
        ERROR_VC_DISCONNECTED = 0xF0,
        /// <summary>
        /// The specified extended attribute name was invalid.
        /// </summary>
        ERROR_INVALID_EA_NAME = 0xFE,
        /// <summary>
        /// The extended attributes are inconsistent.
        /// </summary>
        ERROR_EA_LIST_INCONSISTENT = 0xFF,
        /// <summary>
        /// The wait operation timed out.
        /// </summary>
        WAIT_TIMEOUT = 0x102,
        /// <summary>
        /// No more data is available.
        /// </summary>
        ERROR_NO_MORE_ITEMS = 0x103,
        /// <summary>
        /// The copy functions cannot be used.
        /// </summary>
        ERROR_CANNOT_COPY = 0x10A,
        /// <summary>
        /// The directory name is invalid.
        /// </summary>
        ERROR_DIRECTORY = 0x10B,
        /// <summary>
        /// The extended attributes did not fit in the buffer.
        /// </summary>
        ERROR_EAS_DIDNT_FIT = 0x113,
        /// <summary>
        /// The extended attribute file on the mounted file system is corrupt.
        /// </summary>
        ERROR_EA_FILE_CORRUPT = 0x114,
        /// <summary>
        /// The extended attribute table file is full.
        /// </summary>
        ERROR_EA_TABLE_FULL = 0x115,
        /// <summary>
        /// The specified extended attribute handle is invalid.
        /// </summary>
        ERROR_INVALID_EA_HANDLE = 0x116,
        /// <summary>
        /// The mounted file system does not support extended attributes.
        /// </summary>
        ERROR_EAS_NOT_SUPPORTED = 0x11A,
        /// <summary>
        /// Attempt to release mutex not owned by caller.
        /// </summary>
        ERROR_NOT_OWNER = 0x120,
        /// <summary>
        /// Too many posts were made to a semaphore.
        /// </summary>
        ERROR_TOO_MANY_POSTS = 0x12A,
        /// <summary>
        /// Only part of a ReadProcessMemory or WriteProcessMemory request was completed.
        /// </summary>
        ERROR_PARTIAL_COPY = 0x12B,
        /// <summary>
        /// The oplock request is denied.
        /// </summary>
        ERROR_OPLOCK_NOT_GRANTED = 0x12C,
        /// <summary>
        /// An invalid oplock acknowledgment was received by the system.
        /// </summary>
        ERROR_INVALID_OPLOCK_PROTOCOL = 0x12D,
        /// <summary>
        /// The volume is too fragmented to complete this operation.
        /// </summary>
        ERROR_DISK_TOO_FRAGMENTED = 0x12E,
        /// <summary>
        /// The file cannot be opened because it is in the process of being deleted.
        /// </summary>
        ERROR_DELETE_PENDING = 0x12F,
        /// <summary>
        /// Short name settings may not be changed on this volume due to the global registry setting.
        /// </summary>
        ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 0x130,
        /// <summary>
        /// Short names are not enabled on this volume.
        /// </summary>
        ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 0x131,
        /// <summary>
        /// The security stream for the given volume is in an inconsistent state. Please run CHKDSK on the volume.
        /// </summary>
        ERROR_SECURITY_STREAM_IS_INCONSISTENT = 0x132,
        /// <summary>
        /// A requested file lock operation cannot be processed due to an invalid byte range.
        /// </summary>
        ERROR_INVALID_LOCK_RANGE = 0x133,
        /// <summary>
        /// The subsystem needed to support the image type is not present.
        /// </summary>
        ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 0x134,
        /// <summary>
        /// The specified file already has a notification GUID associated with it.
        /// </summary>
        ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 0x135,
        /// <summary>
        /// An invalid exception handler routine has been detected.
        /// </summary>
        ERROR_INVALID_EXCEPTION_HANDLER = 0x136,
        /// <summary>
        /// Duplicate privileges were specified for the token.
        /// </summary>
        ERROR_DUPLICATE_PRIVILEGES = 0x137,
        /// <summary>
        /// No ranges for the specified operation were able to be processed.
        /// </summary>
        ERROR_NO_RANGES_PROCESSED = 0x138,
        /// <summary>
        /// Operation is not allowed on a file system internal file.
        /// </summary>
        ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 0x139,
        /// <summary>
        /// The physical resources of this disk have been exhausted.
        /// </summary>
        ERROR_DISK_RESOURCES_EXHAUSTED = 0x13A,
        /// <summary>
        /// The token representing the data is invalid.
        /// </summary>
        ERROR_INVALID_TOKEN = 0x13B,
        /// <summary>
        /// The device does not support the command feature.
        /// </summary>
        ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 0x13C,
        /// <summary>
        /// The system cannot find message text for message number 0x%1 in the message file for %2.
        /// </summary>
        ERROR_MR_MID_NOT_FOUND = 0x13D,
        /// <summary>
        /// The scope specified was not found.
        /// </summary>
        ERROR_SCOPE_NOT_FOUND = 0x13E,
        /// <summary>
        /// The Central Access Policy specified is not defined on the target machine.
        /// </summary>
        ERROR_UNDEFINED_SCOPE = 0x13F,
        /// <summary>
        /// The Central Access Policy obtained from Active Directory is invalid.
        /// </summary>
        ERROR_INVALID_CAP = 0x140,
        /// <summary>
        /// The device is unreachable.
        /// </summary>
        ERROR_DEVICE_UNREACHABLE = 0x141,
        /// <summary>
        /// The target device has insufficient resources to complete the operation.
        /// </summary>
        ERROR_DEVICE_NO_RESOURCES = 0x142,
        /// <summary>
        /// A data integrity checksum error occurred. Data in the file stream is corrupt.
        /// </summary>
        ERROR_DATA_CHECKSUM_ERROR = 0x143,
        /// <summary>
        /// An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in the same operation.
        /// </summary>
        ERROR_INTERMIXED_KERNEL_EA_OPERATION = 0x144,
        /// <summary>
        /// Device does not support file-level TRIM.
        /// </summary>
        ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 0x146,
        /// <summary>
        /// The command specified a data offset that does not align to the device's granularity/alignment.
        /// </summary>
        ERROR_OFFSET_ALIGNMENT_VIOLATION = 0x147,
        /// <summary>
        /// The command specified an invalid field in its parameter list.
        /// </summary>
        ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 0x148,
        /// <summary>
        /// An operation is currently in progress with the device.
        /// </summary>
        ERROR_OPERATION_IN_PROGRESS = 0x149,
        /// <summary>
        /// An attempt was made to send down the command via an invalid path to the target device.
        /// </summary>
        ERROR_BAD_DEVICE_PATH = 0x14A,
        /// <summary>
        /// The command specified a number of descriptors that exceeded the maximum supported by the device.
        /// </summary>
        ERROR_TOO_MANY_DESCRIPTORS = 0x14B,
        /// <summary>
        /// Scrub is disabled on the specified file.
        /// </summary>
        ERROR_SCRUB_DATA_DISABLED = 0x14C,
        /// <summary>
        /// The storage device does not provide redundancy.
        /// </summary>
        ERROR_NOT_REDUNDANT_STORAGE = 0x14D,
        /// <summary>
        /// An operation is not supported on a resident file.
        /// </summary>
        ERROR_RESIDENT_FILE_NOT_SUPPORTED = 0x14E,
        /// <summary>
        /// An operation is not supported on a compressed file.
        /// </summary>
        ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 0x14F,
        /// <summary>
        /// An operation is not supported on a directory.
        /// </summary>
        ERROR_DIRECTORY_NOT_SUPPORTED = 0x150,
        /// <summary>
        /// The specified copy of the requested data could not be read.
        /// </summary>
        ERROR_NOT_READ_FROM_COPY = 0x151,
        /// <summary>
        /// No action was taken as a system reboot is required.
        /// </summary>
        ERROR_FAIL_NOACTION_REBOOT = 0x15E,
        /// <summary>
        /// The shutdown operation failed.
        /// </summary>
        ERROR_FAIL_SHUTDOWN = 0x15F,
        /// <summary>
        /// The restart operation failed.
        /// </summary>
        ERROR_FAIL_RESTART = 0x160,
        /// <summary>
        /// The maximum number of sessions has been reached.
        /// </summary>
        ERROR_MAX_SESSIONS_REACHED = 0x161,
        /// <summary>
        /// The thread is already in background processing mode.
        /// </summary>
        ERROR_THREAD_MODE_ALREADY_BACKGROUND = 0x190,
        /// <summary>
        /// The thread is not in background processing mode.
        /// </summary>
        ERROR_THREAD_MODE_NOT_BACKGROUND = 0x191,
        /// <summary>
        /// The process is already in background processing mode.
        /// </summary>
        ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 0x192,
        /// <summary>
        /// The process is not in background processing mode.
        /// </summary>
        ERROR_PROCESS_MODE_NOT_BACKGROUND = 0x193,
        /// <summary>
        /// Attempt to access invalid address.
        /// </summary>
        ERROR_INVALID_ADDRESS = 0x1E7,

        #endregion

        #region 500 - 999

        /// <summary>
        /// User profile cannot be loaded.
        /// </summary>
        ERROR_USER_PROFILE_LOAD = 0x1F4,
        /// <summary>
        /// Arithmetic result exceeded 32 bits.
        /// </summary>
        ERROR_ARITHMETIC_OVERFLOW = 0x216,
        /// <summary>
        /// There is a process on other end of the pipe.
        /// </summary>
        ERROR_PIPE_CONNECTED = 0x217,
        /// <summary>
        /// Waiting for a process to open the other end of the pipe.
        /// </summary>
        ERROR_PIPE_LISTENING = 0x218,
        /// <summary>
        /// Application verifier has found an error in the current process.
        /// </summary>
        ERROR_VERIFIER_STOP = 0x219,
        /// <summary>
        /// An error occurred in the ABIOS subsystem.
        /// </summary>
        ERROR_ABIOS_ERROR = 0x21A,
        /// <summary>
        /// A warning occurred in the WX86 subsystem.
        /// </summary>
        ERROR_WX86_WARNING = 0x21B,
        /// <summary>
        /// An error occurred in the WX86 subsystem.
        /// </summary>
        ERROR_WX86_ERROR = 0x21C,
        /// <summary>
        /// An attempt was made to cancel or set a timer that has an associated APC and the subject thread is not the 
        /// thread that originally set the timer with an associated APC routine.
        /// </summary>
        ERROR_TIMER_NOT_CANCELED = 0x21D,
        /// <summary>
        /// Unwind exception code.
        /// </summary>
        ERROR_UNWIND = 0x21E,
        /// <summary>
        /// An invalid or unaligned stack was encountered during an unwind operation.
        /// </summary>
        ERROR_BAD_STACK = 0x21F,
        /// <summary>
        /// An invalid unwind target was encountered during an unwind operation.
        /// </summary>
        ERROR_INVALID_UNWIND_TARGET = 0x220,
        /// <summary>
        /// Invalid Object Attributes specified to NtCreatePort or invalid Port Attributes specified to NtConnectPort
        /// </summary>
        ERROR_INVALID_PORT_ATTRIBUTES = 0x221,
        /// <summary>
        /// Length of message passed to NtRequestPort or NtRequestWaitReplyPort was longer than the maximum message allowed by the port.
        /// </summary>
        ERROR_PORT_MESSAGE_TOO_LONG = 0x222,
        /// <summary>
        /// An attempt was made to lower a quota limit below the current usage.
        /// </summary>
        ERROR_INVALID_QUOTA_LOWER = 0x223,
        /// <summary>
        /// An attempt was made to attach to a device that was already attached to another device.
        /// </summary>
        ERROR_DEVICE_ALREADY_ATTACHED = 0x224,
        /// <summary>
        /// An attempt was made to execute an instruction at an unaligned address and the host system does not support unaligned instruction references.
        /// </summary>
        ERROR_INSTRUCTION_MISALIGNMENT = 0x225,
        /// <summary>
        /// Profiling not started.
        /// </summary>
        ERROR_PROFILING_NOT_STARTED = 0x226,
        /// <summary>
        /// Profiling not stopped.
        /// </summary>
        ERROR_PROFILING_NOT_STOPPED = 0x227,
        /// <summary>
        /// The passed ACL did not contain the minimum required information.
        /// </summary>
        ERROR_COULD_NOT_INTERPRET = 0x228,
        /// <summary>
        /// The number of active profiling objects is at the maximum and no more may be started.
        /// </summary>
        ERROR_PROFILING_AT_LIMIT = 0x229,
        /// <summary>
        /// Used to indicate that an operation cannot continue without blocking for I/O.
        /// </summary>
        ERROR_CANT_WAIT = 0x22A,
        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter
        /// correctly handles the exception.
        /// </summary>
        ERROR_UNEXPECTED_MM_CREATE_ERR = 0x22C,
        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the 
        /// following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter
        /// correctly handles the exception.
        /// </summary>
        ERROR_UNEXPECTED_MM_MAP_ERROR = 0x22D,
        /// <summary>
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the 
        /// following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter
        /// correctly handles the exception.
        /// </summary>
        ERROR_UNEXPECTED_MM_EXTEND_ERR = 0x22E,
        /// <summary>
        /// A malformed function table was encountered during an unwind operation.
        /// </summary>
        ERROR_BAD_FUNCTION_TABLE = 0x22F,
        /// <summary>
        /// Indicates that an attempt was made to assign protection to a file system file or directory and one of the 
        /// SIDs in the security descriptor could not be translated into a GUID that could be stored by the file system. This
        /// causes the protection attempt to fail, which may cause a file creation attempt to fail.
        /// </summary>
        ERROR_NO_GUID_TRANSLATION = 0x230,
        /// <summary>
        /// Indicates that an attempt was made to grow an LDT by setting its size, or that the size was not an even number of selectors.
        /// </summary>
        ERROR_INVALID_LDT_SIZE = 0x231,
        /// <summary>
        /// Indicates that the starting value for the LDT information was not an integral multiple of the selector size.
        /// </summary>
        ERROR_INVALID_LDT_OFFSET = 0x233,
        /// <summary>
        /// Indicates that the user supplied an invalid descriptor when trying to set up Ldt descriptors.
        /// </summary>
        ERROR_INVALID_LDT_DESCRIPTOR = 0x234,
        /// <summary>
        /// Indicates a process has too many threads to perform the requested action. For example, assignment of a primary token may only be performed when a process has zero or one threads.
        /// </summary>
        ERROR_TOO_MANY_THREADS = 0x235,
        /// <summary>
        /// An attempt was made to operate on a thread within a specific process, but the thread specified is not in the  process specified.
        /// </summary>
        ERROR_THREAD_NOT_IN_PROCESS = 0x236,
        /// <summary>
        /// Page file quota was exceeded.
        /// </summary>
        ERROR_PAGEFILE_QUOTA_EXCEEDED = 0x237,
        /// <summary>
        /// The Netlogon service cannot start because another Netlogon service running in the domain conflicts with the specified role.
        /// </summary>
        ERROR_LOGON_SERVER_CONFLICT = 0x238,
        /// <summary>
        /// The SAM database on a Windows Server is significantly out of synchronization with the copy on the Domain  Controller. A complete synchronization is required.
        /// </summary>
        ERROR_SYNCHRONIZATION_REQUIRED = 0x239,
        /// <summary>
        /// The NtCreateFile API failed. This error should never be returned to an application, it is a place holder for the Windows Lan Manager Redirector to use in its internal error mapping routines.
        /// </summary>
        ERROR_NET_OPEN_FAILED = 0x23A,
        /// <summary>
        /// {Privilege Failed} The I/O permissions for the process could not be changed.
        /// </summary>
        ERROR_IO_PRIVILEGE_FAILED = 0x23B,
        /// <summary>
        /// {Application Exit by CTRL+C} The application terminated as a result of a CTRL+C.
        /// </summary>
        ERROR_CONTROL_C_EXIT = 0x23C,
        /// <summary>
        /// {Missing System File} The required system file %hs is bad or missing.
        /// </summary>
        ERROR_MISSING_SYSTEMFILE = 0x23D,
        /// <summary>
        /// {Application Error} The exception %s (0x%08lx) occurred in the application at location 0x%08lx.
        /// </summary>
        ERROR_UNHANDLED_EXCEPTION = 0x23E,
        /// <summary>
        /// {Application Error} The application was unable to start correctly (0x%lx). Click OK to close the application.
        /// </summary>
        ERROR_APP_INIT_FAILURE = 0x23F,
        /// <summary>
        /// {Unable to Create Paging File} The creation of the paging file %hs failed (%lx). The requested size was %ld.
        /// </summary>
        ERROR_PAGEFILE_CREATE_FAILED = 0x240,
        /// <summary>
        /// Windows cannot verify the digital signature for this file. A recent hardware or software change might have 
        ///  installed a file that is signed incorrectly or damaged, or that might be malicious software from an unknown
        ///  source.
        /// </summary>
        ERROR_INVALID_IMAGE_HASH = 0x241,
        /// <summary>
        /// {No Paging File Specified} No paging file was specified in the system configuration.
        /// </summary>
        ERROR_NO_PAGEFILE = 0x242,
        /// <summary>
        /// {EXCEPTION} A real-mode application issued a floating-point instruction and floating-point hardware is not  present.
        /// </summary>
        ERROR_ILLEGAL_FLOAT_CONTEXT = 0x243,
        /// <summary>
        /// An event pair synchronization operation was performed using the thread specific client/server event pair 
        /// object, but no event pair object was associated with the thread.
        /// </summary>
        ERROR_NO_EVENT_PAIR = 0x244,
        /// <summary>
        /// A Windows Server has an incorrect configuration.
        /// </summary>
        ERROR_DOMAIN_CTRLR_CONFIG_ERROR = 0x245,
        /// <summary>
        /// An illegal character was encountered. For a multi-byte character set this includes a lead byte without a 
        /// succeeding trail byte. For the Unicode character set this includes the characters 0xFFFF and 0xFFFE.
        /// </summary>
        ERROR_ILLEGAL_CHARACTER = 0x246,
        /// <summary>
        /// The Unicode character is not defined in the Unicode character set installed on the system.
        /// </summary>
        ERROR_UNDEFINED_CHARACTER = 0x247,
        /// <summary>
        /// The paging file cannot be created on a floppy diskette.
        /// </summary>
        ERROR_FLOPPY_VOLUME = 0x248,
        /// <summary>
        /// The system BIOS failed to connect a system interrupt to the device or bus for which the device is connected.
        /// </summary>
        ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT = 0x249,
        /// <summary>
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        ERROR_BACKUP_CONTROLLER = 0x24A,
        /// <summary>
        /// An attempt was made to acquire a mutant such that its maximum count would have been exceeded.
        /// </summary>
        ERROR_MUTANT_LIMIT_EXCEEDED = 0x24B,
        /// <summary>
        /// A volume has been accessed for which a file system driver is required that has not yet been loaded.
        /// </summary>
        ERROR_FS_DRIVER_REQUIRED = 0x24C,
        /// <summary>
        /// {Registry File Failure} The registry cannot load the hive (file): %hs or its log or alternate. It is corrupt, absent, or not writable.
        /// </summary>
        ERROR_CANNOT_LOAD_REGISTRY_FILE = 0x24D,
        /// <summary>
        /// {Fatal System Error} The %hs system process terminated unexpectedly with a status of 0x%08x (0x%08x 0x%08x). The system has been shut down.
        /// </summary>
        ERROR_SYSTEM_PROCESS_TERMINATED = 0x24F,
        /// <summary>
        /// {Data Not Accepted} The TDI client could not handle the data received during an indication.
        /// </summary>
        ERROR_DATA_NOT_ACCEPTED = 0x250,
        /// <summary>
        /// NTVDM encountered a hard error.
        /// </summary>
        ERROR_VDM_HARD_ERROR = 0x251,
        /// <summary>
        /// {Cancel Timeout} The driver %hs failed to complete a cancelled I/O request in the allotted time.
        /// </summary>
        ERROR_DRIVER_CANCEL_TIMEOUT = 0x252,
        /// <summary>
        /// {Reply Message Mismatch} An attempt was made to reply to an LPC message, but the thread specified by the 
        ///  client ID in the message was not waiting on that message.
        /// </summary>
        ERROR_REPLY_MESSAGE_MISMATCH = 0x253,
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs. The data has been lost. 
        ///    This error may be caused by a failure of your computer hardware or network connection.Please try to save this
        ///       file elsewhere.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA = 0x254,
        /// <summary>
        /// The parameter(s) passed to the server in the client/server shared memory window were invalid. Too much data 
        ///  may have been put in the shared memory window.
        /// </summary>
        ERROR_CLIENT_SERVER_PARAMETERS_INVALID = 0x255,
        /// <summary>
        /// The stream is not a tiny stream.
        /// </summary>
        ERROR_NOT_TINY_STREAM = 0x256,
        /// <summary>
        /// The request must be handled by the stack overflow code.
        /// </summary>
        ERROR_STACK_OVERFLOW_READ = 0x257,
        /// <summary>
        /// Internal OFS status codes indicating how an allocation operation is handled. Either it is retried after the 
        ///   containing onode is moved or the extent stream is converted to a large stream.
        /// </summary>
        ERROR_CONVERT_TO_LARGE = 0x258,
        /// <summary>
        /// The attempt to find the object found an object matching by ID on the volume but it is out of the scope of 
        ///   the handle used for the operation.
        /// </summary>
        ERROR_FOUND_OUT_OF_SCOPE = 0x259,
        /// <summary>
        /// The bucket array must be grown. Retry transaction after doing so.
        /// </summary>
        ERROR_ALLOCATE_BUCKET = 0x25A,
        /// <summary>
        /// The user/kernel marshalling buffer has overflowed.
        /// </summary>
        ERROR_MARSHALL_OVERFLOW = 0x25B,
        /// <summary>
        /// The supplied variant structure contains invalid data.
        /// </summary>
        ERROR_INVALID_VARIANT = 0x25C,
        /// <summary>
        /// The specified buffer contains ill-formed data.
        /// </summary>
        ERROR_BAD_COMPRESSION_BUFFER = 0x25D,
        /// <summary>
        /// {Audit Failed} An attempt to generate a security audit failed.
        /// </summary>
        ERROR_AUDIT_FAILED = 0x25E,
        /// <summary>
        /// The timer resolution was not previously set by the current process.
        /// </summary>
        ERROR_TIMER_RESOLUTION_NOT_SET = 0x25F,
        /// <summary>
        /// There is insufficient account information to log you on.
        /// </summary>
        ERROR_INSUFFICIENT_LOGON_INFO = 0x260,
        /// <summary>
        /// {Invalid DLL Entrypoint} The dynamic link library %hs is not written correctly. The stack pointer has been 
        ///    left in an inconsistent state.The entrypoint should be declared as WINAPI or STDCALL.Select YES to fail the
        ///      DLL load.Select NO to continue execution.Selecting NO may cause the application to operate incorrectly.
        /// </summary>
        ERROR_BAD_DLL_ENTRYPOINT = 0x261,
        /// <summary>
        /// {Invalid Service Callback Entrypoint} The %hs service is not written correctly. The stack pointer has been 
        ///    left in an inconsistent state.The callback entrypoint should be declared as WINAPI or STDCALL. Selecting OK will
        ///     cause the service to continue operation.However, the service process may operate incorrectly.
        /// </summary>
        ERROR_BAD_SERVICE_ENTRYPOINT = 0x262,
        /// <summary>
        /// There is an IP address conflict with another system on the network.
        /// </summary>
        ERROR_IP_ADDRESS_CONFLICT1 = 0x263,
        /// <summary>
        /// There is an IP address conflict with another system on the network.
        /// </summary>
        ERROR_IP_ADDRESS_CONFLICT2 = 0x264,
        /// <summary>
        /// {Low On Registry Space} The system has reached the maximum size allowed for the system part of the registry. 
        ///    Additional storage requests will be ignored.
        /// </summary>
        ERROR_REGISTRY_QUOTA_LIMIT = 0x265,
        /// <summary>
        /// A callback return system service cannot be executed when no callback is active.
        /// </summary>
        ERROR_NO_CALLBACK_ACTIVE = 0x266,
        /// <summary>
        /// The password provided is too short to meet the policy of your user account. Please choose a longer 
        ///   password.
        /// </summary>
        ERROR_PWD_TOO_SHORT = 0x267,
        /// <summary>
        /// The policy of your user account does not allow you to change passwords too frequently. This is done to 
        /// prevent users from changing back to a familiar, but potentially discovered, password. If you feel your password
        /// has been compromised then please contact your administrator immediately to have a new one assigned.
        /// </summary>
        ERROR_PWD_TOO_RECENT = 0x268,
        /// <summary>
        /// You have attempted to change your password to one that you have used in the past. The policy of your user 
        /// account does not allow this.Please select a password that you have not previously used.
        /// </summary>
        ERROR_PWD_HISTORY_CONFLICT = 0x269,
        /// <summary>
        /// The specified compression format is unsupported.
        /// </summary>
        ERROR_UNSUPPORTED_COMPRESSION = 0x26A,
        /// <summary>
        /// The specified hardware profile configuration is invalid.
        /// </summary>
        ERROR_INVALID_HW_PROFILE = 0x26B,
        /// <summary>
        /// The specified Plug and Play registry device path is invalid.
        /// </summary>
        ERROR_INVALID_PLUGPLAY_DEVICE_PATH = 0x26C,
        /// <summary>
        /// The specified quota list is internally inconsistent with its descriptor.
        /// </summary>
        ERROR_QUOTA_LIST_INCONSISTENT = 0x26D,
        /// <summary>
        /// {Windows Evaluation Notification} The evaluation period for this installation of Windows has expired. This 
        /// system will shutdown in 1 hour.To restore access to this installation of Windows, please upgrade this
        /// installation using a licensed distribution of this product.
        /// </summary>
        ERROR_EVALUATION_EXPIRATION = 0x26E,
        /// <summary>
        /// {Illegal System DLL Relocation} The system DLL %hs was relocated in memory. The application will not run 
        /// properly.The relocation occurred because the DLL % hs occupied an address range reserved for Windows system DLLs.
        /// The vendor supplying the DLL should be contacted for a new DLL.
        /// </summary>
        ERROR_ILLEGAL_DLL_RELOCATION = 0x26F,
        /// <summary>
        /// {DLL Initialization Failed} The application failed to initialize because the window station is shutting 
        /// down.
        /// </summary>
        ERROR_DLL_INIT_FAILED_LOGOFF = 0x270,
        /// <summary>
        /// The validation process needs to continue on to the next step.
        /// </summary>
        ERROR_VALIDATE_CONTINUE = 0x271,
        /// <summary>
        /// There are no more matches for the current index enumeration.
        /// </summary>
        ERROR_NO_MORE_MATCHES = 0x272,
        /// <summary>
        /// The range could not be added to the range list because of a conflict.
        /// </summary>
        ERROR_RANGE_LIST_CONFLICT = 0x273,
        /// <summary>
        /// The server process is running under a SID different than that required by client.
        /// </summary>
        ERROR_SERVER_SID_MISMATCH = 0x274,
        /// <summary>
        /// A group marked use for deny only cannot be enabled.
        /// </summary>
        ERROR_CANT_ENABLE_DENY_ONLY = 0x275,
        /// <summary>
        /// {EXCEPTION} Multiple floating point faults.
        /// </summary>
        ERROR_FLOAT_MULTIPLE_FAULTS = 0x276,
        /// <summary>
        /// {EXCEPTION} Multiple floating point traps.
        /// </summary>
        ERROR_FLOAT_MULTIPLE_TRAPS = 0x277,
        /// <summary>
        /// The requested interface is not supported.
        /// </summary>
        ERROR_NOINTERFACE = 0x278,
        /// <summary>
        /// {System Standby Failed} The driver %hs does not support standby mode. Updating this driver may allow the 
        /// system to go to standby mode.
        /// </summary>
        ERROR_DRIVER_FAILED_SLEEP = 0x279,
        /// <summary>
        /// The system file %1 has become corrupt and has been replaced.
        /// </summary>
        ERROR_CORRUPT_SYSTEM_FILE = 0x27A,
        /// <summary>
        /// {Virtual Memory Minimum Too Low} Your system is low on virtual memory. Windows is increasing the size of 
        /// your virtual memory paging file.During this process, memory requests for some applications may be denied.For
        /// more information, see Help.
        /// </summary>
        ERROR_COMMITMENT_MINIMUM = 0x27B,
        /// <summary>
        /// A device was removed so enumeration must be restarted.
        /// </summary>
        ERROR_PNP_RESTART_ENUMERATION = 0x27C,
        /// <summary>
        /// {Fatal System Error} The system image %s is not properly signed. The file has been replaced with the signed 
        /// file.The system has been shut down.
        /// </summary>
        ERROR_SYSTEM_IMAGE_BAD_SIGNATURE = 0x27D,
        /// <summary>
        /// Device will not start without a reboot.
        /// </summary>
        ERROR_PNP_REBOOT_REQUIRED = 0x27E,
        /// <summary>
        /// There is not enough power to complete the requested operation.
        /// </summary>
        ERROR_INSUFFICIENT_POWER = 0x27F,
        /// <summary>
        /// ERROR_MULTIPLE_FAULT_VIOLATION
        /// </summary>
        ERROR_MULTIPLE_FAULT_VIOLATION = 0x280,
        /// <summary>
        /// The system is in the process of shutting down.
        /// </summary>
        ERROR_SYSTEM_SHUTDOWN = 0x281,
        /// <summary>
        /// An attempt to remove a processes DebugPort was made, but a port was not already associated with the 
        /// process.
        /// </summary>
        ERROR_PORT_NOT_SET = 0x282,
        /// <summary>
        /// This version of Windows is not compatible with the behavior version of directory forest, domain or domain 
        /// controller.
        /// </summary>
        ERROR_DS_VERSION_CHECK_FAILURE = 0x283,
        /// <summary>
        /// The specified range could not be found in the range list.
        /// </summary>
        ERROR_RANGE_NOT_FOUND = 0x284,
        /// <summary>
        /// The driver was not loaded because the system is booting into safe mode.
        /// </summary>
        ERROR_NOT_SAFE_MODE_DRIVER = 0x286,
        /// <summary>
        /// The driver was not loaded because it failed its initialization call.
        /// </summary>
        ERROR_FAILED_DRIVER_ENTRY = 0x287,
        /// <summary>
        /// The "%hs" encountered an error while applying power or reading the device configuration. This may be caused 
        /// by a failure of your hardware or by a poor connection.
        /// </summary>
        ERROR_DEVICE_ENUMERATION_ERROR = 0x288,
        /// <summary>
        /// The create operation failed because the name contained at least one mount point which resolves to a volume 
        /// to which the specified device object is not attached.
        /// </summary>
        ERROR_MOUNT_POINT_NOT_RESOLVED = 0x289,
        /// <summary>
        /// The device object parameter is either not a valid device object or is not attached to the volume specified 
        /// by the file name.
        /// </summary>
        ERROR_INVALID_DEVICE_OBJECT_PARAMETER = 0x28A,
        /// <summary>
        /// A Machine Check Error has occurred. Please check the system eventlog for additional information.
        /// </summary>
        ERROR_MCA_OCCURED = 0x28B,
        /// <summary>
        /// There was error [%2] processing the driver database.
        /// </summary>
        ERROR_DRIVER_DATABASE_ERROR = 0x28C,
        /// <summary>
        /// System hive size has exceeded its limit.
        /// </summary>
        ERROR_SYSTEM_HIVE_TOO_LARGE = 0x28D,
        /// <summary>
        /// The driver could not be loaded because a previous version of the driver is still in memory.
        /// </summary>
        ERROR_DRIVER_FAILED_PRIOR_UNLOAD = 0x28E,
        /// <summary>
        /// {Volume Shadow Copy Service} Please wait while the Volume Shadow Copy Service prepares volume %hs for 
        /// hibernation.
        /// </summary>
        ERROR_VOLSNAP_PREPARE_HIBERNATE = 0x28F,
        /// <summary>
        /// The system has failed to hibernate (The error code is %hs). Hibernation will be disabled until the system is restarted.
        /// </summary>
        ERROR_HIBERNATION_FAILURE = 0x290,
        /// <summary>
        /// The password provided is too long to meet the policy of your user account. Please choose a shorter password.
        /// </summary>
        ERROR_PWD_TOO_LONG = 0x291,
        /// <summary>
        /// The requested operation could not be completed due to a file system limitation.
        /// </summary>
        ERROR_FILE_SYSTEM_LIMITATION = 0x299,
        /// <summary>
        /// An assertion failure has occurred.
        /// </summary>
        ERROR_ASSERTION_FAILURE = 0x29C,
        /// <summary>
        /// An error occurred in the ACPI subsystem.
        /// </summary>
        ERROR_ACPI_ERROR = 0x29D,
        /// <summary>
        /// WOW Assertion Error.
        /// </summary>
        ERROR_WOW_ASSERTION = 0x29E,
        /// <summary>
        /// A device is missing in the system BIOS MPS table. This device will not be used. Please contact your system 
        /// vendor for system BIOS update.
        /// </summary>
        ERROR_PNP_BAD_MPS_TABLE = 0x29F,
        /// <summary>
        /// A translator failed to translate resources.
        /// </summary>
        ERROR_PNP_TRANSLATION_FAILED = 0x2A0,
        /// <summary>
        /// A IRQ translator failed to translate resources.
        /// </summary>
        ERROR_PNP_IRQ_TRANSLATION_FAILED = 0x2A1,
        /// <summary>
        /// Driver %2 returned invalid ID for a child device (%3).
        /// </summary>
        ERROR_PNP_INVALID_ID = 0x2A2,
        /// <summary>
        /// {Kernel Debugger Awakened} the system debugger was awakened by an interrupt.
        /// </summary>
        ERROR_WAKE_SYSTEM_DEBUGGER = 0x2A3,
        /// <summary>
        /// {Handles Closed} Handles to objects have been automatically closed as a result of the requested operation.
        /// </summary>
        ERROR_HANDLES_CLOSED = 0x2A4,
        /// <summary>
        /// {Too Much Information} The specified access control list (ACL) contained more information than was expected.
        /// </summary>
        ERROR_EXTRANEOUS_INFORMATION = 0x2A5,
        /// <summary>
        /// This warning level status indicates that the transaction state already exists for the registry sub-tree, but 
        /// that a transaction commit was previously aborted.The commit has NOT been completed, but has not been rolled back
        /// either(so it may still be committed if desired).
        /// </summary>
        ERROR_RXACT_COMMIT_NECESSARY = 0x2A6,
        /// <summary>
        /// {Media Changed} The media may have changed.
        /// </summary>
        ERROR_MEDIA_CHECK = 0x2A7,
        /// <summary>
        /// {GUID Substitution} During the translation of a global identifier (GUID) to a Windows security ID (SID), no 
        /// administratively - defined GUID prefix was found. A substitute prefix was used, which will not compromise system
        /// security.However, this may provide a more restrictive access than intended.
        /// </summary>
        ERROR_GUID_SUBSTITUTION_MADE = 0x2A8,
        /// <summary>
        /// The create operation stopped after reaching a symbolic link.
        /// </summary>
        ERROR_STOPPED_ON_SYMLINK = 0x2A9,
        /// <summary>
        /// A long jump has been executed.
        /// </summary>
        ERROR_LONGJUMP = 0x2AA,
        /// <summary>
        /// The Plug and Play query operation was not successful.
        /// </summary>
        ERROR_PLUGPLAY_QUERY_VETOED = 0x2AB,
        /// <summary>
        /// A frame consolidation has been executed.
        /// </summary>
        ERROR_UNWIND_CONSOLIDATE = 0x2AC,
        /// <summary>
        /// {Registry Hive Recovered} Registry hive (file): %hs was corrupted and it has been recovered. Some data might 
        /// have been lost.
        /// </summary>
        ERROR_REGISTRY_HIVE_RECOVERED = 0x2AD,
        /// <summary>
        /// The application is attempting to run executable code from the module %hs. This may be insecure. An 
        /// alternative, % hs, is available.Should the application use the secure module % hs ?
        /// </summary>
        ERROR_DLL_MIGHT_BE_INSECURE = 0x2AE,
        /// <summary>
        /// The application is loading executable code from the module %hs. This is secure, but may be incompatible with 
        /// previous releases of the operating system. An alternative, % hs, is available.Should the application use the
        ///secure module % hs ?
        /// </summary>
        ERROR_DLL_MIGHT_BE_INCOMPATIBLE = 0x2AF,
        /// <summary>
        /// Debugger did not handle the exception.
        /// </summary>
        ERROR_DBG_EXCEPTION_NOT_HANDLED = 0x2B0,
        /// <summary>
        /// Debugger will reply later.
        /// </summary>
        ERROR_DBG_REPLY_LATER = 0x2B1,
        /// <summary>
        /// Debugger cannot provide handle.
        /// </summary>
        ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE = 0x2B2,
        /// <summary>
        /// Debugger terminated thread.
        /// </summary>
        ERROR_DBG_TERMINATE_THREAD = 0x2B3,
        /// <summary>
        /// Debugger terminated process.
        /// </summary>
        ERROR_DBG_TERMINATE_PROCESS = 0x2B4,
        /// <summary>
        /// Debugger got control C.
        /// </summary>
        ERROR_DBG_CONTROL_C = 0x2B5,
        /// <summary>
        /// Debugger printed exception on control C.
        /// </summary>
        ERROR_DBG_PRINTEXCEPTION_C = 0x2B6,
        /// <summary>
        /// Debugger received RIP exception.
        /// </summary>
        ERROR_DBG_RIPEXCEPTION = 0x2B7,
        /// <summary>
        /// Debugger received control break.
        /// </summary>
        ERROR_DBG_CONTROL_BREAK = 0x2B8,
        /// <summary>
        /// Debugger command communication exception.
        /// </summary>
        ERROR_DBG_COMMAND_EXCEPTION = 0x2B9,
        /// <summary>
        /// {Object Exists} An attempt was made to create an object and the object name already existed.
        /// </summary>
        ERROR_OBJECT_NAME_EXISTS = 0x2BA,
        /// <summary>
        /// {Thread Suspended} A thread termination occurred while the thread was suspended. The thread was resumed, and 
        /// termination proceeded.
        /// </summary>
        ERROR_THREAD_WAS_SUSPENDED = 0x2BB,
        /// <summary>
        /// {Image Relocated} An image file could not be mapped at the address specified in the image file. Local fixups 
        /// must be performed on this image.
        /// </summary>
        ERROR_IMAGE_NOT_AT_BASE = 0x2BC,
        /// <summary>
        /// This informational level status indicates that a specified registry sub-tree transaction state did not yet 
        /// exist and had to be created.
        /// </summary>
        ERROR_RXACT_STATE_CREATED = 0x2BD,
        /// <summary>
        /// {Segment Load} A virtual DOS machine (VDM) is loading, unloading, or moving an MS-DOS or Win16 program 
        /// segment image. An exception is raised so a debugger can load, unload or track symbols and breakpoints within
        /// these 16 - bit segments.
        /// </summary>
        ERROR_SEGMENT_NOTIFICATION = 0x2BE,
        /// <summary>
        /// {Invalid Current Directory} The process cannot switch to the startup current directory %hs. Select OK to set 
        /// current directory to % hs, or select CANCEL to exit.
        /// </summary>
        ERROR_BAD_CURRENT_DIRECTORY = 0x2BF,
        /// <summary>
        /// {Redundant Read} To satisfy a read request, the NT fault-tolerant file system successfully read the 
        /// requested data from a redundant copy.This was done because the file system encountered a failure on a member of
        /// the fault - tolerant volume, but was unable to reassign the failing area of the device.
        /// </summary>
        ERROR_FT_READ_RECOVERY_FROM_BACKUP = 0x2C0,
        /// <summary>
        /// {Redundant Write} To satisfy a write request, the NT fault-tolerant file system successfully wrote a 
        /// redundant copy of the information.This was done because the file system encountered a failure on a member of the
        /// fault - tolerant volume, but was not able to reassign the failing area of the device.
        /// </summary>
        ERROR_FT_WRITE_RECOVERY = 0x2C1,
        /// <summary>
        /// {Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current 
        /// machine.Select OK to continue, or CANCEL to fail the DLL load.
        /// </summary>
        ERROR_IMAGE_MACHINE_TYPE_MISMATCH = 0x2C2,
        /// <summary>
        /// {Partial Data Received} The network transport returned partial data to its client. The remaining data will 
        /// be sent later.
        /// </summary>
        ERROR_RECEIVE_PARTIAL = 0x2C3,
        /// <summary>
        /// {Expedited Data Received} The network transport returned data to its client that was marked as expedited by 
        /// the remote system.
        /// </summary>
        ERROR_RECEIVE_EXPEDITED = 0x2C4,
        /// <summary>
        /// {Partial Expedited Data Received} The network transport returned partial data to its client and this data 
        /// was marked as expedited by the remote system. The remaining data will be sent later.
        /// </summary>
        ERROR_RECEIVE_PARTIAL_EXPEDITED = 0x2C5,
        /// <summary>
        /// {TDI Event Done} The TDI indication has completed successfully.
        /// </summary>
        ERROR_EVENT_DONE = 0x2C6,
        /// <summary>
        /// {TDI Event Pending} The TDI indication has entered the pending state.
        /// </summary>
        ERROR_EVENT_PENDING = 0x2C7,
        /// <summary>
        /// Checking file system on %wZ.
        /// </summary>
        ERROR_CHECKING_FILE_SYSTEM = 0x2C8,
        /// <summary>
        /// {Fatal Application Exit} %hs.
        /// </summary>
        ERROR_FATAL_APP_EXIT = 0x2C9,
        /// <summary>
        /// The specified registry key is referenced by a predefined handle.
        /// </summary>
        ERROR_PREDEFINED_HANDLE = 0x2CA,
        /// <summary>
        /// {Page Unlocked} The page protection of a locked page was changed to 'No Access' and the page was unlocked 
        /// from memory and from the process.
        /// </summary>
        ERROR_WAS_UNLOCKED = 0x2CB,
        /// <summary>
        /// %hs
        /// </summary>
        ERROR_SERVICE_NOTIFICATION = 0x2CC,
        /// <summary>
        /// {Page Locked} One of the pages to lock was already locked.
        /// </summary>
        ERROR_WAS_LOCKED = 0x2CD,
        /// <summary>
        /// Application popup: %1 : %2
        /// </summary>
        ERROR_LOG_HARD_ERROR = 0x2CE,
        /// <summary>
        /// ERROR_ALREADY_WIN32
        /// </summary>
        ERROR_ALREADY_WIN32 = 0x2CF,
        /// <summary>
        /// {Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current 
        /// machine.
        /// </summary>
        ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 0x2D0,
        /// <summary>
        /// A yield execution was performed and no thread was available to run.
        /// </summary>
        ERROR_NO_YIELD_PERFORMED = 0x2D1,
        /// <summary>
        /// The resumable flag to a timer API was ignored.
        /// </summary>
        ERROR_TIMER_RESUME_IGNORED = 0x2D2,
        /// <summary>
        /// The arbiter has deferred arbitration of these resources to its parent.
        /// </summary>
        ERROR_ARBITRATION_UNHANDLED = 0x2D3,
        /// <summary>
        /// The inserted CardBus device cannot be started because of a configuration error on "%hs".
        /// </summary>
        ERROR_CARDBUS_NOT_SUPPORTED = 0x2D4,
        /// <summary>
        /// The CPUs in this multiprocessor system are not all the same revision level. To use all processors the 
        /// operating system restricts itself to the features of the least capable processor in the system. Should problems
        /// occur with this system, contact the CPU manufacturer to see if this mix of processors is supported.
        /// </summary>
        ERROR_MP_PROCESSOR_MISMATCH = 0x2D5,
        /// <summary>
        /// The system was put into hibernation.
        /// </summary>
        ERROR_HIBERNATED = 0x2D6,
        /// <summary>
        /// The system was resumed from hibernation.
        /// </summary>
        ERROR_RESUME_HIBERNATION = 0x2D7,
        /// <summary>
        /// Windows has detected that the system firmware (BIOS) was updated [previous firmware date = %2, current 
        /// firmware date % 3].
        /// </summary>
        ERROR_FIRMWARE_UPDATED = 0x2D8,
        /// <summary>
        /// A device driver is leaking locked I/O pages causing system degradation. The system has automatically enabled 
        /// tracking code in order to try and catch the culprit.
        /// </summary>
        ERROR_DRIVERS_LEAKING_LOCKED_PAGES = 0x2D9,
        /// <summary>
        /// The system has awoken.
        /// </summary>
        ERROR_WAKE_SYSTEM = 0x2DA,
        /// <summary>
        /// ERROR_WAIT_1
        /// </summary>
        ERROR_WAIT_1 = 0x2DB,
        /// <summary>
        /// ERROR_WAIT_2
        /// </summary>
        ERROR_WAIT_2 = 0x2DC,
        /// <summary>
        /// ERROR_WAIT_3
        /// </summary>
        ERROR_WAIT_3 = 0x2DD,
        /// <summary>
        /// ERROR_WAIT_63
        /// </summary>
        ERROR_WAIT_63 = 0x2DE,
        /// <summary>
        /// ERROR_ABANDONED_WAIT_0
        /// </summary>
        ERROR_ABANDONED_WAIT_0 = 0x2DF,
        /// <summary>
        /// ERROR_ABANDONED_WAIT_63
        /// </summary>
        ERROR_ABANDONED_WAIT_63 = 0x2E0,
        /// <summary>
        /// ERROR_USER_APC
        /// </summary>
        ERROR_USER_APC = 0x2E1,
        /// <summary>
        /// ERROR_KERNEL_APC
        /// </summary>
        ERROR_KERNEL_APC = 0x2E2,
        /// <summary>
        /// ERROR_ALERTED
        /// </summary>
        ERROR_ALERTED = 0x2E3,
        /// <summary>
        /// The requested operation requires elevation.
        /// </summary>
        ERROR_ELEVATION_REQUIRED = 0x2E4,
        /// <summary>
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        ERROR_REPARSE = 0x2E5,
        /// <summary>
        /// An open/create operation completed while an oplock break is underway.
        /// </summary>
        ERROR_OPLOCK_BREAK_IN_PROGRESS = 0x2E6,
        /// <summary>
        /// A new volume has been mounted by a file system.
        /// </summary>
        ERROR_VOLUME_MOUNTED = 0x2E7,
        /// <summary>
        /// This success level status indicates that the transaction state already exists for the registry sub-tree, but 
        ///  that a transaction commit was previously aborted.The commit has now been completed.
        /// </summary>
        ERROR_RXACT_COMMITTED = 0x2E8,
        /// <summary>
        /// This indicates that a notify change request has been completed due to closing the handle which made the 
        /// notify change request.
        /// </summary>
        ERROR_NOTIFY_CLEANUP = 0x2E9,
        /// <summary>
        /// {Connect Failure on Primary Transport} An attempt was made to connect to the remote server %hs on the 
        /// primary transport, but the connection failed.The computer WAS able to connect on a secondary transport.
        /// </summary>
        ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED = 0x2EA,
        /// <summary>
        /// Page fault was a transition fault.
        /// </summary>
        ERROR_PAGE_FAULT_TRANSITION = 0x2EB,
        /// <summary>
        /// Page fault was a demand zero fault.
        /// </summary>
        ERROR_PAGE_FAULT_DEMAND_ZERO = 0x2EC,
        /// <summary>
        /// Page fault was a demand zero fault.
        /// </summary>
        ERROR_PAGE_FAULT_COPY_ON_WRITE = 0x2ED,
        /// <summary>
        /// Page fault was a demand zero fault.
        /// </summary>
        ERROR_PAGE_FAULT_GUARD_PAGE = 0x2EE,
        /// <summary>
        /// Page fault was satisfied by reading from a secondary storage device.
        /// </summary>
        ERROR_PAGE_FAULT_PAGING_FILE = 0x2EF,
        /// <summary>
        /// Cached page was locked during operation.
        /// </summary>
        ERROR_CACHE_PAGE_LOCKED = 0x2F0,
        /// <summary>
        /// Crash dump exists in paging file.
        /// </summary>
        ERROR_CRASH_DUMP = 0x2F1,
        /// <summary>
        /// Specified buffer contains all zeros.
        /// </summary>
        ERROR_BUFFER_ALL_ZEROS = 0x2F2,
        /// <summary>
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        ERROR_REPARSE_OBJECT = 0x2F3,
        /// <summary>
        /// The device has succeeded a query-stop and its resource requirements have changed.
        /// </summary>
        ERROR_RESOURCE_REQUIREMENTS_CHANGED = 0x2F4,
        /// <summary>
        /// The translator has translated these resources into the global space and no further translations should be 
        /// performed.
        /// </summary>
        ERROR_TRANSLATION_COMPLETE = 0x2F5,
        /// <summary>
        /// A process being terminated has no threads to terminate.
        /// </summary>
        ERROR_NOTHING_TO_TERMINATE = 0x2F6,
        /// <summary>
        /// The specified process is not part of a job.
        /// </summary>
        ERROR_PROCESS_NOT_IN_JOB = 0x2F7,
        /// <summary>
        /// The specified process is part of a job.
        /// </summary>
        ERROR_PROCESS_IN_JOB = 0x2F8,
        /// <summary>
        /// {Volume Shadow Copy Service} The system is now ready for hibernation.
        /// </summary>
        ERROR_VOLSNAP_HIBERNATE_READY = 0x2F9,
        /// <summary>
        /// A file system or file system filter driver has successfully completed an FsFilter operation.
        /// </summary>
        ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 0x2FA,
        /// <summary>
        /// The specified interrupt vector was already connected.
        /// </summary>
        ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED = 0x2FB,
        /// <summary>
        /// The specified interrupt vector is still connected.
        /// </summary>
        ERROR_INTERRUPT_STILL_CONNECTED = 0x2FC,
        /// <summary>
        /// An operation is blocked waiting for an oplock.
        /// </summary>
        ERROR_WAIT_FOR_OPLOCK = 0x2FD,
        /// <summary>
        /// Debugger handled exception.
        /// </summary>
        ERROR_DBG_EXCEPTION_HANDLED = 0x2FE,
        /// <summary>
        /// Debugger continued.
        /// </summary>
        ERROR_DBG_CONTINUE = 0x2FF,
        /// <summary>
        /// An exception occurred in a user mode callback and the kernel callback frame should be removed.
        /// </summary>
        ERROR_CALLBACK_POP_STACK = 0x300,
        /// <summary>
        /// Compression is disabled for this volume.
        /// </summary>
        ERROR_COMPRESSION_DISABLED = 0x301,
        /// <summary>
        /// The data provider cannot fetch backwards through a result set.
        /// </summary>
        ERROR_CANTFETCHBACKWARDS = 0x302,
        /// <summary>
        /// The data provider cannot scroll backwards through a result set.
        /// </summary>
        ERROR_CANTSCROLLBACKWARDS = 0x303,
        /// <summary>
        /// The data provider requires that previously fetched data is released before asking for more data.
        /// </summary>
        ERROR_ROWSNOTRELEASED = 0x304,
        /// <summary>
        /// The data provider was not able to interpret the flags set for a column binding in an accessor.
        /// </summary>
        ERROR_BAD_ACCESSOR_FLAGS = 0x305,
        /// <summary>
        /// One or more errors occurred while processing the request.
        /// </summary>
        ERROR_ERRORS_ENCOUNTERED = 0x306,
        /// <summary>
        /// The implementation is not capable of performing the request.
        /// </summary>
        ERROR_NOT_CAPABLE = 0x307,
        /// <summary>
        /// The client of a component requested an operation which is not valid given the state of the component instance.
        /// </summary>
        ERROR_REQUEST_OUT_OF_SEQUENCE = 0x308,
        /// <summary>
        /// A version number could not be parsed.
        /// </summary>
        ERROR_VERSION_PARSE_ERROR = 0x309,
        /// <summary>
        /// The iterator's start position is invalid.
        /// </summary>
        ERROR_BADSTARTPOSITION = 0x30A,
        /// <summary>
        /// The hardware has reported an uncorrectable memory error.
        /// </summary>
        ERROR_MEMORY_HARDWARE = 0x30B,
        /// <summary>
        /// The attempted operation required self healing to be enabled.
        /// </summary>
        ERROR_DISK_REPAIR_DISABLED = 0x30C,
        /// <summary>
        /// The Desktop heap encountered an error while allocating session memory. There is more information in the  system event log.
        /// </summary>
        ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = 0x30D,
        /// <summary>
        /// The system power state is transitioning from %2 to %3.
        /// </summary>
        ERROR_SYSTEM_POWERSTATE_TRANSITION = 0x30E,
        /// <summary>
        /// The system power state is transitioning from %2 to %3 but could enter %4.
        /// </summary>
        ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 0x30F,
        /// <summary>
        /// A thread is getting dispatched with MCA EXCEPTION because of MCA.
        /// </summary>
        ERROR_MCA_EXCEPTION = 0x310,
        /// <summary>
        /// Access to %1 is monitored by policy rule %2.
        /// </summary>
        ERROR_ACCESS_AUDIT_BY_POLICY = 0x311,
        /// <summary>
        /// Access to %1 has been restricted by your Administrator by policy rule %2.
        /// </summary>
        ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 0x312,
        /// <summary>
        /// A valid hibernation file has been invalidated and should be abandoned.
        /// </summary>
        ERROR_ABANDON_HIBERFILE = 0x313,
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. 
        /// This error may be caused by network connectivity issues.Please try to save this file elsewhere.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = 0x314,
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. 
        /// This error was returned by the server on which the file exists. Please try to save this file elsewhere.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = 0x315,
        /// <summary>
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. 
        /// This error may be caused if the device has been removed or the media is write -protected.
        /// </summary>
        ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = 0x316,
        /// <summary>
        /// The resources required for this device conflict with the MCFG table.
        /// </summary>
        ERROR_BAD_MCFG_TABLE = 0x317,
        /// <summary>
        /// The volume repair could not be performed while it is online. Please schedule to take the volume offline so 
        /// that it can be repaired.
        /// </summary>
        ERROR_DISK_REPAIR_REDIRECTED = 0x318,
        /// <summary>
        /// The volume repair was not successful.
        /// </summary>
        ERROR_DISK_REPAIR_UNSUCCESSFUL = 0x319,
        /// <summary>
        /// One of the volume corruption logs is full. Further corruptions that may be detected won't be logged.
        /// </summary>
        ERROR_CORRUPT_LOG_OVERFULL = 0x31A,
        /// <summary>
        /// One of the volume corruption logs is internally corrupted and needs to be recreated. The volume may contain 
        /// undetected corruptions and must be scanned.
        /// </summary>
        ERROR_CORRUPT_LOG_CORRUPTED = 0x31B,
        /// <summary>
        /// One of the volume corruption logs is unavailable for being operated on.
        /// </summary>
        ERROR_CORRUPT_LOG_UNAVAILABLE = 0x31C,
        /// <summary>
        /// One of the volume corruption logs was deleted while still having corruption records in them. The volume 
        /// contains detected corruptions and must be scanned.
        /// </summary>
        ERROR_CORRUPT_LOG_DELETED_FULL = 0x31D,
        /// <summary>
        /// One of the volume corruption logs was cleared by chkdsk and no longer contains real corruptions.
        /// </summary>
        ERROR_CORRUPT_LOG_CLEARED = 0x31E,
        /// <summary>
        /// Orphaned files exist on the volume but could not be recovered because no more new names could be created in 
        /// the recovery directory.Files must be moved from the recovery directory.
        /// </summary>
        ERROR_ORPHAN_NAME_EXHAUSTED = 0x31F,
        /// <summary>
        /// The oplock that was associated with this handle is now associated with a different handle.
        /// </summary>
        ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE = 0x320,
        /// <summary>
        /// An oplock of the requested level cannot be granted. An oplock of a lower level may be available.
        /// </summary>
        ERROR_CANNOT_GRANT_REQUESTED_OPLOCK = 0x321,
        /// <summary>
        /// The operation did not complete successfully because it would cause an oplock to be broken. The caller has 
        /// requested that existing oplocks not be broken.
        /// </summary>
        ERROR_CANNOT_BREAK_OPLOCK = 0x322,
        /// <summary>
        /// The handle with which this oplock was associated has been closed. The oplock is now broken.
        /// </summary>
        ERROR_OPLOCK_HANDLE_CLOSED = 0x323,
        /// <summary>
        /// The specified access control entry (ACE) does not contain a condition.
        /// </summary>
        ERROR_NO_ACE_CONDITION = 0x324,
        /// <summary>
        /// The specified access control entry (ACE) contains an invalid condition.
        /// </summary>
        ERROR_INVALID_ACE_CONDITION = 0x325,
        /// <summary>
        /// Access to the specified file handle has been revoked.
        /// </summary>
        ERROR_FILE_HANDLE_REVOKED = 0x326,
        /// <summary>
        /// An image file was mapped at a different address from the one specified in the image file but fixups will still be automatically performed on the image.
        /// </summary>
        ERROR_IMAGE_AT_DIFFERENT_BASE = 0x327,
        /// <summary>
        /// Access to the extended attribute was denied.
        /// </summary>
        ERROR_EA_ACCESS_DENIED = 0x3E2,
        /// <summary>
        /// The I/O operation has been aborted because of either a thread exit or an application request.
        /// </summary>
        ERROR_OPERATION_ABORTED = 0x3E3,
        /// <summary>
        /// Overlapped I/O event is not in a signaled state.
        /// </summary>
        ERROR_IO_INCOMPLETE = 0x3E4,
        /// <summary>
        /// Overlapped I/O operation is in progress.
        /// </summary>
        ERROR_IO_PENDING = 0x3E5,
        /// <summary>
        /// Invalid access to memory location.
        /// </summary>
        ERROR_NOACCESS = 0x3E6,
        /// <summary>
        /// Error performing inpage operation.
        /// </summary>
        ERROR_SWAPERROR = 0x3E7,

        #endregion

        #region 1000 - 1299
        /// <summary>
        /// Recursion too deep; the stack overflowed.
        /// </summary>
        ERROR_STACK_OVERFLOW = 0x3E9,
        /// <summary>
        /// The window cannot act on the sent message.
        /// </summary>
        ERROR_INVALID_MESSAGE = 0x3EA,
        /// <summary>
        /// Cannot complete this function.
        /// </summary>
        ERROR_CAN_NOT_COMPLETE = 0x3EB,
        /// <summary>
        /// Invalid flags.
        /// </summary>
        ERROR_INVALID_FLAGS = 0x3EC,
        /// <summary>
        /// The volume does not contain a recognized file system. Please make sure that all required file system drivers 
        /// are loaded and that the volume is not corrupted.
        /// </summary>
        ERROR_UNRECOGNIZED_VOLUME = 0x3ED,
        /// <summary>
        /// The volume for a file has been externally altered so that the opened file is no longer valid.
        /// </summary>
        ERROR_FILE_INVALID = 0x3EE,
        /// <summary>
        /// The requested operation cannot be performed in full-screen mode.
        /// </summary>
        ERROR_FULLSCREEN_MODE = 0x3EF,
        /// <summary>
        /// An attempt was made to reference a token that does not exist.
        /// </summary>
        ERROR_NO_TOKEN = 0x3F0,
        /// <summary>
        /// The configuration registry database is corrupt.
        /// </summary>
        ERROR_BADDB = 0x3F1,
        /// <summary>
        /// The configuration registry key is invalid.
        /// </summary>
        ERROR_BADKEY = 0x3F2,
        /// <summary>
        /// The configuration registry key could not be opened.
        /// </summary>
        ERROR_CANTOPEN = 0x3F3,
        /// <summary>
        /// The configuration registry key could not be read.
        /// </summary>
        ERROR_CANTREAD = 0x3F4,
        /// <summary>
        /// The configuration registry key could not be written.
        /// </summary>
        ERROR_CANTWRITE = 0x3F5,
        /// <summary>
        /// One of the files in the registry database had to be recovered by use of a log or alternate copy. The 
        /// recovery was successful.
        /// </summary>
        ERROR_REGISTRY_RECOVERED = 0x3F6,
        /// <summary>
        /// The registry is corrupted. The structure of one of the files containing registry data is corrupted, or the 
        /// system's memory image of the file is corrupted, or the file could not be recovered because the alternate copy or 
        /// log was absent or corrupted.
        /// </summary>
        ERROR_REGISTRY_CORRUPT = 0x3F7,
        /// <summary>
        /// An I/O operation initiated by the registry failed unrecoverably. The registry could not read in, or write 
        /// out, or flush, one of the files that contain the system's image of the registry.
        /// </summary>
        ERROR_REGISTRY_IO_FAILED = 0x3F8,
        /// <summary>
        /// The system has attempted to load or restore a file into the registry, but the specified file is not in a 
        /// registry file format.
        /// </summary>
        ERROR_NOT_REGISTRY_FILE = 0x3F9,
        /// <summary>
        /// Illegal operation attempted on a registry key that has been marked for deletion.
        /// </summary>
        ERROR_KEY_DELETED = 0x3FA,
        /// <summary>
        /// System could not allocate the required space in a registry log.
        /// </summary>
        ERROR_NO_LOG_SPACE = 0x3FB,
        /// <summary>
        /// Cannot create a symbolic link in a registry key that already has subkeys or values.
        /// </summary>
        ERROR_KEY_HAS_CHILDREN = 0x3FC,
        /// <summary>
        /// Cannot create a stable subkey under a volatile parent key.
        /// </summary>
        ERROR_CHILD_MUST_BE_VOLATILE = 0x3FD,
        /// <summary>
        /// A notify change request is being completed and the information is not being returned in the caller's 
        /// buffer. The caller now needs to enumerate the files to find the changes.
        /// </summary>
        ERROR_NOTIFY_ENUM_DIR = 0x3FE,
        /// <summary>
        /// A stop control has been sent to a service that other running services are dependent on.
        /// </summary>
        ERROR_DEPENDENT_SERVICES_RUNNING = 0x41B,
        /// <summary>
        /// The requested control is not valid for this service.
        /// </summary>
        ERROR_INVALID_SERVICE_CONTROL = 0x41C,
        /// <summary>
        /// The service did not respond to the start or control request in a timely fashion.
        /// </summary>
        ERROR_SERVICE_REQUEST_TIMEOUT = 0x41D,
        /// <summary>
        /// A thread could not be created for the service.
        /// </summary>
        ERROR_SERVICE_NO_THREAD = 0x41E,
        /// <summary>
        /// The service database is locked.
        /// </summary>
        ERROR_SERVICE_DATABASE_LOCKED = 0x41F,
        /// <summary>
        /// An instance of the service is already running.
        /// </summary>
        ERROR_SERVICE_ALREADY_RUNNING = 0x420,
        /// <summary>
        /// The account name is invalid or does not exist, or the password is invalid for the account name specified.
        /// </summary>
        ERROR_INVALID_SERVICE_ACCOUNT = 0x421,
        /// <summary>
        /// The service cannot be started, either because it is disabled or because it has no enabled devices associated with it.
        /// </summary>
        ERROR_SERVICE_DISABLED = 0x422,
        /// <summary>
        /// Circular service dependency was specified.
        /// </summary>
        ERROR_CIRCULAR_DEPENDENCY = 0x423,
        /// <summary>
        /// The specified service does not exist as an installed service.
        /// </summary>
        ERROR_SERVICE_DOES_NOT_EXIST = 0x424,
        /// <summary>
        /// The service cannot accept control messages at this time.
        /// </summary>
        ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 0x425,
        /// <summary>
        /// The service has not been started.
        /// </summary>
        ERROR_SERVICE_NOT_ACTIVE = 0x426,
        /// <summary>
        /// The service process could not connect to the service controller.
        /// </summary>
        ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 0x427,
        /// <summary>
        /// An exception occurred in the service when handling the control request.
        /// </summary>
        ERROR_EXCEPTION_IN_SERVICE = 0x428,
        /// <summary>
        /// The database specified does not exist.
        /// </summary>
        ERROR_DATABASE_DOES_NOT_EXIST = 0x429,
        /// <summary>
        /// The service has returned a service-specific error code.
        /// </summary>
        ERROR_SERVICE_SPECIFIC_ERROR = 0x42A,
        /// <summary>
        /// The process terminated unexpectedly.
        /// </summary>
        ERROR_PROCESS_ABORTED = 0x42B,
        /// <summary>
        /// The dependency service or group failed to start.
        /// </summary>
        ERROR_SERVICE_DEPENDENCY_FAIL = 0x42C,
        /// <summary>
        /// The service did not start due to a logon failure.
        /// </summary>
        ERROR_SERVICE_LOGON_FAILED = 0x42D,
        /// <summary>
        /// After starting, the service hung in a start-pending state.
        /// </summary>
        ERROR_SERVICE_START_HANG = 0x42E,
        /// <summary>
        /// The specified service database lock is invalid.
        /// </summary>
        ERROR_INVALID_SERVICE_LOCK = 0x42F,
        /// <summary>
        /// The specified service has been marked for deletion.
        /// </summary>
        ERROR_SERVICE_MARKED_FOR_DELETE = 0x430,
        /// <summary>
        /// The specified service already exists.
        /// </summary>
        ERROR_SERVICE_EXISTS = 0x431,
        /// <summary>
        /// The system is currently running with the last-known-good configuration.
        /// </summary>
        ERROR_ALREADY_RUNNING_LKG = 0x432,
        /// <summary>
        /// The dependency service does not exist or has been marked for deletion.
        /// </summary>
        ERROR_SERVICE_DEPENDENCY_DELETED = 0x433,
        /// <summary>
        /// The current boot has already been accepted for use as the last-known-good control set.
        /// </summary>
        ERROR_BOOT_ALREADY_ACCEPTED = 0x434,
        /// <summary>
        /// No attempts to start the service have been made since the last boot.
        /// </summary>
        ERROR_SERVICE_NEVER_STARTED = 0x435,
        /// <summary>
        /// The name is already in use as either a service name or a service display name.
        /// </summary>
        ERROR_DUPLICATE_SERVICE_NAME = 0x436,
        /// <summary>
        /// The account specified for this service is different from the account specified for other services running 
        /// in the same process.
        /// </summary>
        ERROR_DIFFERENT_SERVICE_ACCOUNT = 0x437,
        /// <summary>
        /// Failure actions can only be set for Win32 services, not for drivers.
        /// </summary>
        ERROR_CANNOT_DETECT_DRIVER_FAILURE = 0x438,
        /// <summary>
        /// This service runs in the same process as the service control manager. Therefore, the service control 
        /// manager cannot take action if this service's process terminates unexpectedly.
        /// </summary>
        ERROR_CANNOT_DETECT_PROCESS_ABORT = 0x439,
        /// <summary>
        /// No recovery program has been configured for this service.
        /// </summary>
        ERROR_NO_RECOVERY_PROGRAM = 0x43A,
        /// <summary>
        /// The executable program that this service is configured to run in does not implement the service.
        /// </summary>
        ERROR_SERVICE_NOT_IN_EXE = 0x43B,
        /// <summary>
        /// This service cannot be started in Safe Mode.
        /// </summary>
        ERROR_NOT_SAFEBOOT_SERVICE = 0x43C,
        /// <summary>
        /// The physical end of the tape has been reached.
        /// </summary>
        ERROR_END_OF_MEDIA = 0x44C,
        /// <summary>
        /// A tape access reached a filemark.
        /// </summary>
        ERROR_FILEMARK_DETECTED = 0x44D,
        /// <summary>
        /// The beginning of the tape or a partition was encountered.
        /// </summary>
        ERROR_BEGINNING_OF_MEDIA = 0x44E,
        /// <summary>
        /// A tape access reached the end of a set of files.
        /// </summary>
        ERROR_SETMARK_DETECTED = 0x44F,
        /// <summary>
        /// No more data is on the tape.
        /// </summary>
        ERROR_NO_DATA_DETECTED = 0x450,
        /// <summary>
        /// Tape could not be partitioned.
        /// </summary>
        ERROR_PARTITION_FAILURE = 0x451,
        /// <summary>
        /// When accessing a new tape of a multivolume partition, the current block size is incorrect.
        /// </summary>
        ERROR_INVALID_BLOCK_LENGTH = 0x452,
        /// <summary>
        /// Tape partition information could not be found when loading a tape.
        /// </summary>
        ERROR_DEVICE_NOT_PARTITIONED = 0x453,
        /// <summary>
        /// Unable to lock the media eject mechanism.
        /// </summary>
        ERROR_UNABLE_TO_LOCK_MEDIA = 0x454,
        /// <summary>
        /// Unable to unload the media.
        /// </summary>
        ERROR_UNABLE_TO_UNLOAD_MEDIA = 0x455,
        /// <summary>
        /// The media in the drive may have changed.
        /// </summary>
        ERROR_MEDIA_CHANGED = 0x456,
        /// <summary>
        /// The I/O bus was reset.
        /// </summary>
        ERROR_BUS_RESET = 0x457,
        /// <summary>
        /// No media in drive.
        /// </summary>
        ERROR_NO_MEDIA_IN_DRIVE = 0x458,
        /// <summary>
        /// No mapping for the Unicode character exists in the target multi-byte code page.
        /// </summary>
        ERROR_NO_UNICODE_TRANSLATION = 0x459,
        /// <summary>
        /// A dynamic link library (DLL) initialization routine failed.
        /// </summary>
        ERROR_DLL_INIT_FAILED = 0x45A,
        /// <summary>
        /// A system shutdown is in progress.
        /// </summary>
        ERROR_SHUTDOWN_IN_PROGRESS = 0x45B,
        /// <summary>
        /// Unable to abort the system shutdown because no shutdown was in progress.
        /// </summary>
        ERROR_NO_SHUTDOWN_IN_PROGRESS = 0x45C,
        /// <summary>
        /// The request could not be performed because of an I/O device error.
        /// </summary>
        ERROR_IO_DEVICE = 0x45D,
        /// <summary>
        /// No serial device was successfully initialized. The serial driver will unload.
        /// </summary>
        ERROR_SERIAL_NO_DEVICE = 0x45E,
        /// <summary>
        /// Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least one other 
        /// device that uses that IRQ was already opened.
        /// </summary>
        ERROR_IRQ_BUSY = 0x45F,
        /// <summary>
        /// A serial I/O operation was completed by another write to the serial port. The IOCTL_SERIAL_XOFF_COUNTER 
        /// reached zero.)
        /// </summary>
        ERROR_MORE_WRITES = 0x460,
        /// <summary>
        /// A serial I/O operation completed because the timeout period expired. The IOCTL_SERIAL_XOFF_COUNTER did not 
        /// reach zero.)
        /// </summary>
        ERROR_COUNTER_TIMEOUT = 0x461,
        /// <summary>
        /// No ID address mark was found on the floppy disk.
        /// </summary>
        ERROR_FLOPPY_ID_MARK_NOT_FOUND = 0x462,
        /// <summary>
        /// Mismatch between the floppy disk sector ID field and the floppy disk controller track address.
        /// </summary>
        ERROR_FLOPPY_WRONG_CYLINDER = 0x463,
        /// <summary>
        /// The floppy disk controller reported an error that is not recognized by the floppy disk driver.
        /// </summary>
        ERROR_FLOPPY_UNKNOWN_ERROR = 0x464,
        /// <summary>
        /// The floppy disk controller returned inconsistent results in its registers.
        /// </summary>
        ERROR_FLOPPY_BAD_REGISTERS = 0x465,
        /// <summary>
        /// While accessing the hard disk, a recalibrate operation failed, even after retries.
        /// </summary>
        ERROR_DISK_RECALIBRATE_FAILED = 0x466,
        /// <summary>
        /// While accessing the hard disk, a disk operation failed even after retries.
        /// </summary>
        ERROR_DISK_OPERATION_FAILED = 0x467,
        /// <summary>
        /// While accessing the hard disk, a disk controller reset was needed, but even that failed.
        /// </summary>
        ERROR_DISK_RESET_FAILED = 0x468,
        /// <summary>
        /// Physical end of tape encountered.
        /// </summary>
        ERROR_EOM_OVERFLOW = 0x469,
        /// <summary>
        /// Not enough server storage is available to process this command.
        /// </summary>
        ERROR_NOT_ENOUGH_SERVER_MEMORY = 0x46A,
        /// <summary>
        /// A potential deadlock condition has been detected.
        /// </summary>
        ERROR_POSSIBLE_DEADLOCK = 0x46B,
        /// <summary>
        /// The base address or the file offset specified does not have the proper alignment.
        /// </summary>
        ERROR_MAPPED_ALIGNMENT = 0x46C,
        /// <summary>
        /// An attempt to change the system power state was vetoed by another application or driver.
        /// </summary>
        ERROR_SET_POWER_STATE_VETOED = 0x474,
        /// <summary>
        /// The system BIOS failed an attempt to change the system power state.
        /// </summary>
        ERROR_SET_POWER_STATE_FAILED = 0x475,
        /// <summary>
        /// An attempt was made to create more links on a file than the file system supports.
        /// </summary>
        ERROR_TOO_MANY_LINKS = 0x476,
        /// <summary>
        /// The specified program requires a newer version of Windows.
        /// </summary>
        ERROR_OLD_WIN_VERSION = 0x47E,
        /// <summary>
        /// The specified program is not a Windows or MS-DOS program.
        /// </summary>
        ERROR_APP_WRONG_OS = 0x47F,
        /// <summary>
        /// Cannot start more than one instance of the specified program.
        /// </summary>
        ERROR_SINGLE_INSTANCE_APP = 0x480,
        /// <summary>
        /// The specified program was written for an earlier version of Windows.
        /// </summary>
        ERROR_RMODE_APP = 0x481,
        /// <summary>
        /// One of the library files needed to run this application is damaged.
        /// </summary>
        ERROR_INVALID_DLL = 0x482,
        /// <summary>
        /// No application is associated with the specified file for this operation.
        /// </summary>
        ERROR_NO_ASSOCIATION = 0x483,
        /// <summary>
        /// An error occurred in sending the command to the application.
        /// </summary>
        ERROR_DDE_FAIL = 0x484,
        /// <summary>
        /// One of the library files needed to run this application cannot be found.
        /// </summary>
        ERROR_DLL_NOT_FOUND = 0x485,
        /// <summary>
        /// The current process has used all of its system allowance of handles for Window Manager objects.
        /// </summary>
        ERROR_NO_MORE_USER_HANDLES = 0x486,
        /// <summary>
        /// The message can be used only with synchronous operations.
        /// </summary>
        ERROR_MESSAGE_SYNC_ONLY = 0x487,
        /// <summary>
        /// The indicated source element has no media.
        /// </summary>
        ERROR_SOURCE_ELEMENT_EMPTY = 0x488,
        /// <summary>
        /// The indicated destination element already contains media.
        /// </summary>
        ERROR_DESTINATION_ELEMENT_FULL = 0x489,
        /// <summary>
        /// The indicated element does not exist.
        /// </summary>
        ERROR_ILLEGAL_ELEMENT_ADDRESS = 0x48A,
        /// <summary>
        /// The indicated element is part of a magazine that is not present.
        /// </summary>
        ERROR_MAGAZINE_NOT_PRESENT = 0x48B,
        /// <summary>
        /// The indicated device requires reinitialization due to hardware errors.
        /// </summary>
        ERROR_DEVICE_REINITIALIZATION_NEEDED = 0x48C,
        /// <summary>
        /// The device has indicated that cleaning is required before further operations are attempted.
        /// </summary>
        ERROR_DEVICE_REQUIRES_CLEANING = 0x48D,
        /// <summary>
        /// The device has indicated that its door is open.
        /// </summary>
        ERROR_DEVICE_DOOR_OPEN = 0x48E,
        /// <summary>
        /// The device is not connected.
        /// </summary>
        ERROR_DEVICE_NOT_CONNECTED = 0x48F,
        /// <summary>
        /// Element not found.
        /// </summary>
        ERROR_NOT_FOUND = 0x490,
        /// <summary>
        /// There was no match for the specified key in the index.
        /// </summary>
        ERROR_NO_MATCH = 0x491,
        /// <summary>
        /// The property set specified does not exist on the object.
        /// </summary>
        ERROR_SET_NOT_FOUND = 0x492,
        /// <summary>
        /// The point passed to GetMouseMovePoints is not in the buffer.
        /// </summary>
        ERROR_POINT_NOT_FOUND = 0x493,
        /// <summary>
        /// The tracking (workstation) service is not running.
        /// </summary>
        ERROR_NO_TRACKING_SERVICE = 0x494,
        /// <summary>
        /// The Volume ID could not be found.
        /// </summary>
        ERROR_NO_VOLUME_ID = 0x495,
        /// <summary>
        /// Unable to remove the file to be replaced.
        /// </summary>
        ERROR_UNABLE_TO_REMOVE_REPLACED = 0x497,
        /// <summary>
        /// Unable to move the replacement file to the file to be replaced. The file to be replaced has retained its  original name.
        /// </summary>
        ERROR_UNABLE_TO_MOVE_REPLACEMENT = 0x498,
        /// <summary>
        /// Unable to move the replacement file to the file to be replaced. The file to be replaced has been renamed   using the backup name.
        /// </summary>
        ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 0x499,
        /// <summary>
        /// The volume change journal is being deleted.
        /// </summary>
        ERROR_JOURNAL_DELETE_IN_PROGRESS = 0x49A,
        /// <summary>
        /// The volume change journal is not active.
        /// </summary>
        ERROR_JOURNAL_NOT_ACTIVE = 0x49B,
        /// <summary>
        /// A file was found, but it may not be the correct file.
        /// </summary>
        ERROR_POTENTIAL_FILE_FOUND = 0x49C,
        /// <summary>
        /// The journal entry has been deleted from the journal.
        /// </summary>
        ERROR_JOURNAL_ENTRY_DELETED = 0x49D,
        /// <summary>
        /// A system shutdown has already been scheduled.
        /// </summary>
        ERROR_SHUTDOWN_IS_SCHEDULED = 0x4A6,
        /// <summary>
        /// The system shutdown cannot be initiated because there are other users logged on to the computer.
        /// </summary>
        ERROR_SHUTDOWN_USERS_LOGGED_ON = 0x4A7,
        /// <summary>
        /// The specified device name is invalid.
        /// </summary>
        ERROR_BAD_DEVICE = 0x4B0,
        /// <summary>
        /// The device is not currently connected but it is a remembered connection.
        /// </summary>
        ERROR_CONNECTION_UNAVAIL = 0x4B1,
        /// <summary>
        /// The local device name has a remembered connection to another network resource.
        /// </summary>
        ERROR_DEVICE_ALREADY_REMEMBERED = 0x4B2,
        /// <summary>
        /// The network path was either typed incorrectly, does not exist, or the network provider is not currently available.Please try retyping the path or contact your network administrator.
        /// </summary>
        ERROR_NO_NET_OR_BAD_PATH = 0x4B3,
        /// <summary>
        /// The specified network provider name is invalid.
        /// </summary>
        ERROR_BAD_PROVIDER = 0x4B4,
        /// <summary>
        /// Unable to open the network connection profile.
        /// </summary>
        ERROR_CANNOT_OPEN_PROFILE = 0x4B5,
        /// <summary>
        /// The network connection profile is corrupted.
        /// </summary>
        ERROR_BAD_PROFILE = 0x4B6,
        /// <summary>
        /// Cannot enumerate a noncontainer.
        /// </summary>
        ERROR_NOT_CONTAINER = 0x4B7,
        /// <summary>
        /// An extended error has occurred.
        /// </summary>
        ERROR_EXTENDED_ERROR = 0x4B8,
        /// <summary>
        /// The format of the specified group name is invalid.
        /// </summary>
        ERROR_INVALID_GROUPNAME = 0x4B9,
        /// <summary>
        /// The format of the specified computer name is invalid.
        /// </summary>
        ERROR_INVALID_COMPUTERNAME = 0x4BA,
        /// <summary>
        /// The format of the specified event name is invalid.
        /// </summary>
        ERROR_INVALID_EVENTNAME = 0x4BB,
        /// <summary>
        /// The format of the specified domain name is invalid.
        /// </summary>
        ERROR_INVALID_DOMAINNAME = 0x4BC,
        /// <summary>
        /// The format of the specified service name is invalid.
        /// </summary>
        ERROR_INVALID_SERVICENAME = 0x4BD,
        /// <summary>
        /// The format of the specified network name is invalid.
        /// </summary>
        ERROR_INVALID_NETNAME = 0x4BE,
        /// <summary>
        /// The format of the specified share name is invalid.
        /// </summary>
        ERROR_INVALID_SHARENAME = 0x4BF,
        /// <summary>
        /// The format of the specified password is invalid.
        /// </summary>
        ERROR_INVALID_PASSWORDNAME = 0x4C0,
        /// <summary>
        /// The format of the specified message name is invalid.
        /// </summary>
        ERROR_INVALID_MESSAGENAME = 0x4C1,
        /// <summary>
        /// The format of the specified message destination is invalid.
        /// </summary>
        ERROR_INVALID_MESSAGEDEST = 0x4C2,
        /// <summary>
        /// Multiple connections to a server or shared resource by the same user, using more than one user name, are not 
        /// allowed.Disconnect all previous connections to the server or shared resource and try again.
        /// </summary>
        ERROR_SESSION_CREDENTIAL_CONFLICT = 0x4C3,
        /// <summary>
        /// An attempt was made to establish a session to a network server, but there are already too many sessions 
        /// established to that server.
        /// </summary>
        ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 0x4C4,
        /// <summary>
        /// The workgroup or domain name is already in use by another computer on the network.
        /// </summary>
        ERROR_DUP_DOMAINNAME = 0x4C5,
        /// <summary>
        /// The network is not present or not started.
        /// </summary>
        ERROR_NO_NETWORK = 0x4C6,
        /// <summary>
        /// The operation was canceled by the user.
        /// </summary>
        ERROR_CANCELLED = 0x4C7,
        /// <summary>
        /// The requested operation cannot be performed on a file with a user-mapped section open.
        /// </summary>
        ERROR_USER_MAPPED_FILE = 0x4C8,
        /// <summary>
        /// The remote computer refused the network connection.
        /// </summary>
        ERROR_CONNECTION_REFUSED = 0x4C9,
        /// <summary>
        /// The network connection was gracefully closed.
        /// </summary>
        ERROR_GRACEFUL_DISCONNECT = 0x4CA,
        /// <summary>
        /// The network transport endpoint already has an address associated with it.
        /// </summary>
        ERROR_ADDRESS_ALREADY_ASSOCIATED = 0x4CB,
        /// <summary>
        /// An address has not yet been associated with the network endpoint.
        /// </summary>
        ERROR_ADDRESS_NOT_ASSOCIATED = 0x4CC,
        /// <summary>
        /// An operation was attempted on a nonexistent network connection.
        /// </summary>
        ERROR_CONNECTION_INVALID = 0x4CD,
        /// <summary>
        /// An invalid operation was attempted on an active network connection.
        /// </summary>
        ERROR_CONNECTION_ACTIVE = 0x4CE,
        /// <summary>
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_NETWORK_UNREACHABLE = 0x4CF,
        /// <summary>
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_HOST_UNREACHABLE = 0x4D0,
        /// <summary>
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_PROTOCOL_UNREACHABLE = 0x4D1,
        /// <summary>
        /// No service is operating at the destination network endpoint on the remote system.
        /// </summary>
        ERROR_PORT_UNREACHABLE = 0x4D2,
        /// <summary>
        /// The request was aborted.
        /// </summary>
        ERROR_REQUEST_ABORTED = 0x4D3,
        /// <summary>
        /// The network connection was aborted by the local system.
        /// </summary>
        ERROR_CONNECTION_ABORTED = 0x4D4,
        /// <summary>
        /// The operation could not be completed. A retry should be performed.
        /// </summary>
        ERROR_RETRY = 0x4D5,
        /// <summary>
        /// A connection to the server could not be made because the limit on the number of concurrent connections for  this account has been reached.
        /// </summary>
        ERROR_CONNECTION_COUNT_LIMIT = 0x4D6,
        /// <summary>
        /// Attempting to log in during an unauthorized time of day for this account.
        /// </summary>
        ERROR_LOGIN_TIME_RESTRICTION = 0x4D7,
        /// <summary>
        /// The account is not authorized to log in from this station.
        /// </summary>
        ERROR_LOGIN_WKSTA_RESTRICTION = 0x4D8,
        /// <summary>
        /// The network address could not be used for the operation requested.
        /// </summary>
        ERROR_INCORRECT_ADDRESS = 0x4D9,
        /// <summary>
        /// The service is already registered.
        /// </summary>
        ERROR_ALREADY_REGISTERED = 0x4DA,
        /// <summary>
        /// The specified service does not exist.
        /// </summary>
        ERROR_SERVICE_NOT_FOUND = 0x4DB,
        /// <summary>
        /// The operation being requested was not performed because the user has not been authenticated.
        /// </summary>
        ERROR_NOT_AUTHENTICATED = 0x4DC,
        /// <summary>
        /// The operation being requested was not performed because the user has not logged on to the network. The specified service does not exist.
        /// </summary>
        ERROR_NOT_LOGGED_ON = 0x4DD,
        /// <summary>
        /// Continue with work in progress.
        /// </summary>
        ERROR_CONTINUE = 0x4DE,
        /// <summary>
        /// An attempt was made to perform an initialization operation when initialization has already been completed.
        /// </summary>
        ERROR_ALREADY_INITIALIZED = 0x4DF,
        /// <summary>
        /// No more local devices.
        /// </summary>
        ERROR_NO_MORE_DEVICES = 0x4E0,
        /// <summary>
        /// The specified site does not exist.
        /// </summary>
        ERROR_NO_SUCH_SITE = 0x4E1,
        /// <summary>
        /// A domain controller with the specified name already exists.
        /// </summary>
        ERROR_DOMAIN_CONTROLLER_EXISTS = 0x4E2,
        /// <summary>
        /// This operation is supported only when you are connected to the server.
        /// </summary>
        ERROR_ONLY_IF_CONNECTED = 0x4E3,
        /// <summary>
        /// The group policy framework should call the extension even if there are no changes.
        /// </summary>
        ERROR_OVERRIDE_NOCHANGES = 0x4E4,
        /// <summary>
        /// The specified user does not have a valid profile.
        /// </summary>
        ERROR_BAD_USER_PROFILE = 0x4E5,
        /// <summary>
        /// This operation is not supported on a computer running Windows Server 2003 for Small Business Server.
        /// </summary>
        ERROR_NOT_SUPPORTED_ON_SBS = 0x4E6,
        /// <summary>
        /// The server machine is shutting down.
        /// </summary>
        ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 0x4E7,
        /// <summary>
        /// The remote system is not available. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ERROR_HOST_DOWN = 0x4E8,
        /// <summary>
        /// The security identifier provided is not from an account domain.
        /// </summary>
        ERROR_NON_ACCOUNT_SID = 0x4E9,
        /// <summary>
        /// The security identifier provided does not have a domain component.
        /// </summary>
        ERROR_NON_DOMAIN_SID = 0x4EA,
        /// <summary>
        /// AppHelp dialog canceled thus preventing the application from starting.
        /// </summary>
        ERROR_APPHELP_BLOCK = 0x4EB,
        /// <summary>
        /// This program is blocked by group policy. For more information, contact your system administrator.
        /// </summary>
        ERROR_ACCESS_DISABLED_BY_POLICY = 0x4EC,
        /// <summary>
        /// A program attempt to use an invalid register value. Normally caused by an uninitialized register. This error is Itanium specific.
        /// </summary>
        ERROR_REG_NAT_CONSUMPTION = 0x4ED,
        /// <summary>
        /// The share is currently offline or does not exist.
        /// </summary>
        ERROR_CSCSHARE_OFFLINE = 0x4EE,
        /// <summary>
        /// The Kerberos protocol encountered an error while validating the KDC certificate during smartcard logon. There is more information in the system event log.
        /// </summary>
        ERROR_PKINIT_FAILURE = 0x4EF,
        /// <summary>
        /// The Kerberos protocol encountered an error while attempting to utilize the smartcard subsystem.
        /// </summary>
        ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 0x4F0,
        /// <summary>
        /// The system cannot contact a domain controller to service the authentication request. Please try again later.
        /// </summary>
        ERROR_DOWNGRADE_DETECTED = 0x4F1,
        /// <summary>
        /// The machine is locked and cannot be shut down without the force option.
        /// </summary>
        ERROR_MACHINE_LOCKED = 0x4F7,
        /// <summary>
        /// An application-defined callback gave invalid data when called.
        /// </summary>
        ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 0x4F9,
        /// <summary>
        /// The group policy framework should call the extension in the synchronous foreground policy refresh.
        /// </summary>
        ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 0x4FA,
        /// <summary>
        /// This driver has been blocked from loading.
        /// </summary>
        ERROR_DRIVER_BLOCKED = 0x4FB,
        /// <summary>
        /// A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.
        /// </summary>
        ERROR_INVALID_IMPORT_OF_NON_DLL = 0x4FC,
        /// <summary>
        /// Windows cannot open this program since it has been disabled.
        /// </summary>
        ERROR_ACCESS_DISABLED_WEBBLADE = 0x4FD,
        /// <summary>
        /// Windows cannot open this program because the license enforcement system has been tampered with or become corrupted.
        /// </summary>
        ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 0x4FE,
        /// <summary>
        /// A transaction recover failed.
        /// </summary>
        ERROR_RECOVERY_FAILURE = 0x4FF,
        /// <summary>
        /// The current thread has already been converted to a fiber.
        /// </summary>
        ERROR_ALREADY_FIBER = 0x500,
        /// <summary>
        /// The current thread has already been converted from a fiber.
        /// </summary>
        ERROR_ALREADY_THREAD = 0x501,
        /// <summary>
        /// The system detected an overrun of a stack-based buffer in this application. This overrun could potentially allow a malicious user to gain control of this application.
        /// </summary>
        ERROR_STACK_BUFFER_OVERRUN = 0x502,
        /// <summary>
        /// Data present in one of the parameters is more than the function can operate on.
        /// </summary>
        ERROR_PARAMETER_QUOTA_EXCEEDED = 0x503,
        /// <summary>
        /// An attempt to do an operation on a debug object failed because the object is in the process of being deleted.
        /// </summary>
        ERROR_DEBUGGER_INACTIVE = 0x504,
        /// <summary>
        /// An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.
        /// </summary>
        ERROR_DELAY_LOAD_FAILED = 0x505,
        /// <summary>
        /// %1 is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your permissions with your system administrator.
        /// </summary>
        ERROR_VDM_DISALLOWED = 0x506,
        /// <summary>
        /// Insufficient information exists to identify the cause of failure.
        /// </summary>
        ERROR_UNIDENTIFIED_ERROR = 0x507,
        /// <summary>
        /// The parameter passed to a C runtime function is incorrect.
        /// </summary>
        ERROR_INVALID_CRUNTIME_PARAMETER = 0x508,
        /// <summary>
        /// The operation occurred beyond the valid data length of the file.
        /// </summary>
        ERROR_BEYOND_VDL = 0x509,
        /// <summary>
        /// The service start failed since one or more services in the same process have an incompatible service SID type 
        /// setting.A service with restricted service SID type can only coexist in the same process with other services
        /// with a restricted SID type.If the service SID type for this service was just configured, the hosting process
        /// must be restarted in order to start this service.
        /// </summary>
        ERROR_INCOMPATIBLE_SERVICE_SID_TYPE = 0x50A,
        /// <summary>
        /// The process hosting the driver for this device has been terminated.
        /// </summary>
        ERROR_DRIVER_PROCESS_TERMINATED = 0x50B,
        /// <summary>
        /// An operation attempted to exceed an implementation-defined limit.
        /// </summary>
        ERROR_IMPLEMENTATION_LIMIT = 0x50C,
        /// <summary>
        /// Either the target process, or the target thread's containing process, is a protected process.
        /// </summary>
        ERROR_PROCESS_IS_PROTECTED = 0x50D,
        /// <summary>
        /// The service notification client is lagging too far behind the current state of services in the 
        /// machine.
        /// </summary>
        ERROR_SERVICE_NOTIFY_CLIENT_LAGGING = 0x50E,
        /// <summary>
        /// The requested file operation failed because the storage quota was exceeded. To free up disk space, move 
        /// files to a different location or delete unnecessary files.For more information, contact your system
        /// administrator.
        /// </summary>
        ERROR_DISK_QUOTA_EXCEEDED = 0x50F,
        /// <summary>
        /// The requested file operation failed because the storage policy blocks that type of file. For more 
        /// information, contact your system administrator.
        /// </summary>
        ERROR_CONTENT_BLOCKED = 0x510,
        /// <summary>
        /// A privilege that the service requires to function properly does not exist in the service account 
        /// configuration.You may use the Services Microsoft Management Console (MMC) snap-in (services.msc) and the Local
        /// Security Settings MMC snap-in (secpol.msc) to view the service configuration and the account configuration.
        /// </summary>
        ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE = 0x511,
        /// <summary>
        /// A thread involved in this operation appears to be unresponsive.
        /// </summary>
        ERROR_APP_HANG = 0x512,
        /// <summary>
        /// Indicates a particular Security ID may not be assigned as the label of an object.
        /// </summary>
        ERROR_INVALID_LABEL = 0x513,

        #endregion

        #region 1300 - 1699

        /// <summary>
        /// Not all privileges or groups referenced are assigned to the caller.
        /// </summary>
        ERROR_NOT_ALL_ASSIGNED = 0x514,
        /// <summary>
        /// Some mapping between account names and security IDs was not done.
        /// </summary>
        ERROR_SOME_NOT_MAPPED = 0x515,
        /// <summary>
        /// No system quota limits are specifically set for this account.
        /// </summary>
        ERROR_NO_QUOTAS_FOR_ACCOUNT = 0x516,
        /// <summary>
        /// No encryption key is available. A well-known encryption key was returned.
        /// </summary>
        ERROR_LOCAL_USER_SESSION_KEY = 0x517,
        /// <summary>
        /// The revision level is unknown.
        /// </summary>
        ERROR_UNKNOWN_REVISION = 0x519,
        /// <summary>
        /// Indicates two revision levels are incompatible.
        /// </summary>
        ERROR_REVISION_MISMATCH = 0x51A,
        /// <summary>
        /// This security ID may not be assigned as the owner of this object.
        /// </summary>
        ERROR_INVALID_OWNER = 0x51B,
        /// <summary>
        /// This security ID may not be assigned as the primary group of an object.
        /// </summary>
        ERROR_INVALID_PRIMARY_GROUP = 0x51C,
        /// <summary>
        /// An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.
        /// </summary>
        ERROR_NO_IMPERSONATION_TOKEN = 0x51D,
        /// <summary>
        /// The group may not be disabled.
        /// </summary>
        ERROR_CANT_DISABLE_MANDATORY = 0x51E,
        /// <summary>
        /// There are currently no logon servers available to service the logon request.
        /// </summary>
        ERROR_NO_LOGON_SERVERS = 0x51F,
        /// <summary>
        /// A specified logon session does not exist. It may already have been terminated.
        /// </summary>
        ERROR_NO_SUCH_LOGON_SESSION = 0x520,
        /// <summary>
        /// A specified privilege does not exist.
        /// </summary>
        ERROR_NO_SUCH_PRIVILEGE = 0x521,
        /// <summary>
        /// A required privilege is not held by the client.
        /// </summary>
        ERROR_PRIVILEGE_NOT_HELD = 0x522,
        /// <summary>
        /// The name provided is not a properly formed account name.
        /// </summary>
        ERROR_INVALID_ACCOUNT_NAME = 0x523,
        /// <summary>
        /// The specified account already exists.
        /// </summary>
        ERROR_USER_EXISTS = 0x524,
        /// <summary>
        /// The specified account does not exist.
        /// </summary>
        ERROR_NO_SUCH_USER = 0x525,
        /// <summary>
        /// The specified group already exists.
        /// </summary>
        ERROR_GROUP_EXISTS = 0x526,
        /// <summary>
        /// The specified group does not exist.
        /// </summary>
        ERROR_NO_SUCH_GROUP = 0x527,
        /// <summary>
        /// Either the specified user account is already a member of the specified group, or the specified group cannot be deleted because it contains a member.
        /// </summary>
        ERROR_MEMBER_IN_GROUP = 0x528,
        /// <summary>
        /// The specified user account is not a member of the specified group account.
        /// </summary>
        ERROR_MEMBER_NOT_IN_GROUP = 0x529,
        /// <summary>
        /// This operation is disallowed as it could result in an administration account being disabled, deleted or unable to log on.
        /// </summary>
        ERROR_LAST_ADMIN = 0x52A,
        /// <summary>
        /// Unable to update the password. The value provided as the current password is incorrect.
        /// </summary>
        ERROR_WRONG_PASSWORD = 0x52B,
        /// <summary>
        /// Unable to update the password. The value provided for the new password contains values that are not allowed  in passwords.
        /// </summary>
        ERROR_ILL_FORMED_PASSWORD = 0x52C,
        /// <summary>
        /// Unable to update the password. The value provided for the new password does not meet the length, complexity, or history requirements of the domain.
        /// </summary>
        ERROR_PASSWORD_RESTRICTION = 0x52D,
        /// <summary>
        /// The user name or password is incorrect.
        /// </summary>
        ERROR_LOGON_FAILURE = 0x52E,
        /// <summary>
        /// Account restrictions are preventing this user from signing in. For example: blank passwords aren't allowed, sign-in times are limited, or a policy restriction has been enforced.
        /// </summary>
        ERROR_ACCOUNT_RESTRICTION = 0x52F,
        /// <summary>
        /// Your account has time restrictions that keep you from signing in right now.
        /// </summary>
        ERROR_INVALID_LOGON_HOURS = 0x530,
        /// <summary>
        /// This user isn't allowed to sign in to this computer.
        /// </summary>
        ERROR_INVALID_WORKSTATION = 0x531,
        /// <summary>
        /// The password for this account has expired.
        /// </summary>
        ERROR_PASSWORD_EXPIRED = 0x532,
        /// <summary>
        /// This user can't sign in because this account is currently disabled.
        /// </summary>
        ERROR_ACCOUNT_DISABLED = 0x533,
        /// <summary>
        /// No mapping between account names and security IDs was done.
        /// </summary>
        ERROR_NONE_MAPPED = 0x534,
        /// <summary>
        /// Too many local user identifiers (LUIDs) were requested at one time.
        /// </summary>
        ERROR_TOO_MANY_LUIDS_REQUESTED = 0x535,
        /// <summary>
        /// No more local user identifiers (LUIDs) are available.
        /// </summary>
        ERROR_LUIDS_EXHAUSTED = 0x536,
        /// <summary>
        /// The subauthority part of a security ID is invalid for this particular use.
        /// </summary>
        ERROR_INVALID_SUB_AUTHORITY = 0x537,
        /// <summary>
        /// The access control list (ACL) structure is invalid.
        /// </summary>
        ERROR_INVALID_ACL = 0x538,
        /// <summary>
        /// The security ID structure is invalid.
        /// </summary>
        ERROR_INVALID_SID = 0x539,
        /// <summary>
        /// The security descriptor structure is invalid.
        /// </summary>
        ERROR_INVALID_SECURITY_DESCR = 0x53A,
        /// <summary>
        /// The inherited access control list (ACL) or access control entry (ACE) could not be built.
        /// </summary>
        ERROR_BAD_INHERITANCE_ACL = 0x53C,
        /// <summary>
        /// The server is currently disabled.
        /// </summary>
        ERROR_SERVER_DISABLED = 0x53D,
        /// <summary>
        /// The server is currently enabled.
        /// </summary>
        ERROR_SERVER_NOT_DISABLED = 0x53E,
        /// <summary>
        /// The value provided was an invalid value for an identifier authority.
        /// </summary>
        ERROR_INVALID_ID_AUTHORITY = 0x53F,
        /// <summary>
        /// No more memory is available for security information updates.
        /// </summary>
        ERROR_ALLOTTED_SPACE_EXCEEDED = 0x540,
        /// <summary>
        /// The specified attributes are invalid, or incompatible with the attributes for the group as a whole.
        /// </summary>
        ERROR_INVALID_GROUP_ATTRIBUTES = 0x541,
        /// <summary>
        /// Either a required impersonation level was not provided, or the provided impersonation level is invalid.
        /// </summary>
        ERROR_BAD_IMPERSONATION_LEVEL = 0x542,
        /// <summary>
        /// Cannot open an anonymous level security token.
        /// </summary>
        ERROR_CANT_OPEN_ANONYMOUS = 0x543,
        /// <summary>
        /// The validation information class requested was invalid.
        /// </summary>
        ERROR_BAD_VALIDATION_CLASS = 0x544,
        /// <summary>
        /// The type of the token is inappropriate for its attempted use.
        /// </summary>
        ERROR_BAD_TOKEN_TYPE = 0x545,
        /// <summary>
        /// Unable to perform a security operation on an object that has no associated security.
        /// </summary>
        ERROR_NO_SECURITY_ON_OBJECT = 0x546,
        /// <summary>
        /// Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.
        /// </summary>
        ERROR_CANT_ACCESS_DOMAIN_INFO = 0x547,
        /// <summary>
        /// The security account manager (SAM) or local security authority (LSA) server was in the wrong state to perform the security operation.
        /// </summary>
        ERROR_INVALID_SERVER_STATE = 0x548,
        /// <summary>
        /// The domain was in the wrong state to perform the security operation.
        /// </summary>
        ERROR_INVALID_DOMAIN_STATE = 0x549,
        /// <summary>
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        ERROR_INVALID_DOMAIN_ROLE = 0x54A,
        /// <summary>
        /// The specified domain either does not exist or could not be contacted.
        /// </summary>
        ERROR_NO_SUCH_DOMAIN = 0x54B,
        /// <summary>
        /// The specified domain already exists.
        /// </summary>
        ERROR_DOMAIN_EXISTS = 0x54C,
        /// <summary>
        /// An attempt was made to exceed the limit on the number of domains per server.
        /// </summary>
        ERROR_DOMAIN_LIMIT_EXCEEDED = 0x54D,
        /// <summary>
        /// Unable to complete the requested operation because of either a catastrophic media failure or a data structure corruption on the disk.
/// </summary>
ERROR_INTERNAL_DB_CORRUPTION = 0x54E,
        /// <summary>
        /// An internal error occurred.
        /// </summary>
        ERROR_INTERNAL_ERROR = 0x54F,
        /// <summary>
        /// Generic access types were contained in an access mask which should already be mapped to nongeneric types.
/// </summary>
ERROR_GENERIC_NOT_MAPPED = 0x550,
        /// <summary>
        /// A security descriptor is not in the right format (absolute or self-relative).
        /// </summary>
        ERROR_BAD_DESCRIPTOR_FORMAT = 0x551,
        /// <summary>
        /// The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.
        /// </summary>
        ERROR_NOT_LOGON_PROCESS = 0x552,
        /// <summary>
        /// Cannot start a new logon session with an ID that is already in use.
        /// </summary>
        ERROR_LOGON_SESSION_EXISTS = 0x553,
        /// <summary>
        /// A specified authentication package is unknown.
        /// </summary>
        ERROR_NO_SUCH_PACKAGE = 0x554,
        /// <summary>
        /// The logon session is not in a state that is consistent with the requested operation.
        /// </summary>
        ERROR_BAD_LOGON_SESSION_STATE = 0x555,
        /// <summary>
        /// The logon session ID is already in use.
        /// </summary>
        ERROR_LOGON_SESSION_COLLISION = 0x556,
        /// <summary>
        /// A logon request contained an invalid logon type value.
        /// </summary>
        ERROR_INVALID_LOGON_TYPE = 0x557,
        /// <summary>
        /// Unable to impersonate using a named pipe until data has been read from that pipe.
        /// </summary>
        ERROR_CANNOT_IMPERSONATE = 0x558,
        /// <summary>
        /// The transaction state of a registry subtree is incompatible with the requested operation.
        /// </summary>
        ERROR_RXACT_INVALID_STATE = 0x559,
        /// <summary>
        /// An internal security database corruption has been encountered.
        /// </summary>
        ERROR_RXACT_COMMIT_FAILURE = 0x55A,
        /// <summary>
        /// Cannot perform this operation on built-in accounts.
        /// </summary>
        ERROR_SPECIAL_ACCOUNT = 0x55B,
        /// <summary>
        /// Cannot perform this operation on this built-in special group.
        /// </summary>
        ERROR_SPECIAL_GROUP = 0x55C,
        /// <summary>
        /// Cannot perform this operation on this built-in special user.
        /// </summary>
        ERROR_SPECIAL_USER = 0x55D,
        /// <summary>
        /// The user cannot be removed from a group because the group is currently the user's primary group.
        /// </summary>
        ERROR_MEMBERS_PRIMARY_GROUP = 0x55E,
        /// <summary>
        /// The token is already in use as a primary token.
        /// </summary>
        ERROR_TOKEN_ALREADY_IN_USE = 0x55F,
        /// <summary>
        /// The specified local group does not exist.
        /// </summary>
        ERROR_NO_SUCH_ALIAS = 0x560,
        /// <summary>
        /// The specified account name is not a member of the group.
        /// </summary>
        ERROR_MEMBER_NOT_IN_ALIAS = 0x561,
        /// <summary>
        /// The specified account name is already a member of the group.
        /// </summary>
        ERROR_MEMBER_IN_ALIAS = 0x562,
        /// <summary>
        /// The specified local group already exists.
        /// </summary>
        ERROR_ALIAS_EXISTS = 0x563,
        /// <summary>
        /// Logon failure: the user has not been granted the requested logon type at this computer.
        /// </summary>
        ERROR_LOGON_NOT_GRANTED = 0x564,
        /// <summary>
        /// The maximum number of secrets that may be stored in a single system has been exceeded.
        /// </summary>
        ERROR_TOO_MANY_SECRETS = 0x565,
        /// <summary>
        /// The length of a secret exceeds the maximum length allowed.
        /// </summary>
        ERROR_SECRET_TOO_LONG = 0x566,
        /// <summary>
        /// The local security authority database contains an internal inconsistency.
        /// </summary>
        ERROR_INTERNAL_DB_ERROR = 0x567,
        /// <summary>
        /// During a logon attempt, the user's security context accumulated too many security IDs.
        /// </summary>
        ERROR_TOO_MANY_CONTEXT_IDS = 0x568,
        /// <summary>
        /// Logon failure: the user has not been granted the requested logon type at this computer.
        /// </summary>
        ERROR_LOGON_TYPE_NOT_GRANTED = 0x569,
        /// <summary>
        /// A cross-encrypted password is necessary to change a user password.
        /// </summary>
        ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 0x56A,
        /// <summary>
        /// A member could not be added to or removed from the local group because the member does not exist.
        /// </summary>
        ERROR_NO_SUCH_MEMBER = 0x56B,
        /// <summary>
        /// A new member could not be added to a local group because the member has the wrong account type.
        /// </summary>
        ERROR_INVALID_MEMBER = 0x56C,
        /// <summary>
        /// Too many security IDs have been specified.
        /// </summary>
        ERROR_TOO_MANY_SIDS = 0x56D,
        /// <summary>
        /// A cross-encrypted password is necessary to change this user password.
        /// </summary>
        ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 0x56E,
        /// <summary>
        /// Indicates an ACL contains no inheritable components.
        /// </summary>
        ERROR_NO_INHERITANCE = 0x56F,
        /// <summary>
        /// The file or directory is corrupted and unreadable.
        /// </summary>
        ERROR_FILE_CORRUPT = 0x570,
        /// <summary>
        /// The disk structure is corrupted and unreadable.
        /// </summary>
        ERROR_DISK_CORRUPT = 0x571,
        /// <summary>
        /// There is no user session key for the specified logon session.
        /// </summary>
        ERROR_NO_USER_SESSION_KEY = 0x572,
        /// <summary>
        /// The service being accessed is licensed for a particular number of connections. No more connections can be 
        /// made to the service at this time because there are already as many connections as the service can accept.
        /// </summary>
        ERROR_LICENSE_QUOTA_EXCEEDED = 0x573,
        /// <summary>
        /// The target account name is incorrect.
        /// </summary>
        ERROR_WRONG_TARGET_NAME = 0x574,
        /// <summary>
        /// Mutual Authentication failed. The server's password is out of date at the domain controller.
        /// </summary>
        ERROR_MUTUAL_AUTH_FAILED = 0x575,
        /// <summary>
        /// There is a time and/or date difference between the client and server.
        /// </summary>
        ERROR_TIME_SKEW = 0x576,
        /// <summary>
        /// This operation cannot be performed on the current domain.
        /// </summary>
        ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 0x577,
        /// <summary>
        /// Invalid window handle.
        /// </summary>
        ERROR_INVALID_WINDOW_HANDLE = 0x578,
        /// <summary>
        /// Invalid menu handle.
        /// </summary>
        ERROR_INVALID_MENU_HANDLE = 0x579,
        /// <summary>
        /// Invalid cursor handle.
        /// </summary>
        ERROR_INVALID_CURSOR_HANDLE = 0x57A,
        /// <summary>
        /// Invalid accelerator table handle.
        /// </summary>
        ERROR_INVALID_ACCEL_HANDLE = 0x57B,
        /// <summary>
        /// Invalid hook handle.
        /// </summary>
        ERROR_INVALID_HOOK_HANDLE = 0x57C,
        /// <summary>
        /// Invalid handle to a multiple-window position structure.
        /// </summary>
        ERROR_INVALID_DWP_HANDLE = 0x57D,
        /// <summary>
        /// Cannot create a top-level child window.
        /// </summary>
        ERROR_TLW_WITH_WSCHILD = 0x57E,
        /// <summary>
        /// Cannot find window class.
        /// </summary>
        ERROR_CANNOT_FIND_WND_CLASS = 0x57F,
        /// <summary>
        /// Invalid window; it belongs to other thread.
        /// </summary>
        ERROR_WINDOW_OF_OTHER_THREAD = 0x580,
        /// <summary>
        /// Hot key is already registered.
        /// </summary>
        ERROR_HOTKEY_ALREADY_REGISTERED = 0x581,
        /// <summary>
        /// Class already exists.
        /// </summary>
        ERROR_CLASS_ALREADY_EXISTS = 0x582,
        /// <summary>
        /// Class does not exist.
        /// </summary>
        ERROR_CLASS_DOES_NOT_EXIST = 0x583,
        /// <summary>
        /// Class still has open windows.
        /// </summary>
        ERROR_CLASS_HAS_WINDOWS = 0x584,
        /// <summary>
        /// Invalid index.
        /// </summary>
        ERROR_INVALID_INDEX = 0x585,
        /// <summary>
        /// Invalid icon handle.
        /// </summary>
        ERROR_INVALID_ICON_HANDLE = 0x586,
        /// <summary>
        /// Using private DIALOG window words.
        /// </summary>
        ERROR_PRIVATE_DIALOG_INDEX = 0x587,
        /// <summary>
        /// The list box identifier was not found.
        /// </summary>
        ERROR_LISTBOX_ID_NOT_FOUND = 0x588,
        /// <summary>
        /// No wildcards were found.
        /// </summary>
        ERROR_NO_WILDCARD_CHARACTERS = 0x589,
        /// <summary>
        /// Thread does not have a clipboard open.
        /// </summary>
        ERROR_CLIPBOARD_NOT_OPEN = 0x58A,
        /// <summary>
        /// Hot key is not registered.
        /// </summary>
        ERROR_HOTKEY_NOT_REGISTERED = 0x58B,
        /// <summary>
        /// The window is not a valid dialog window.
        /// </summary>
        ERROR_WINDOW_NOT_DIALOG = 0x58C,
        /// <summary>
        /// Control ID not found.
        /// </summary>
        ERROR_CONTROL_ID_NOT_FOUND = 0x58D,
        /// <summary>
        /// Invalid message for a combo box because it does not have an edit control.
        /// </summary>
        ERROR_INVALID_COMBOBOX_MESSAGE = 0x58E,
        /// <summary>
        /// The window is not a combo box.
        /// </summary>
        ERROR_WINDOW_NOT_COMBOBOX = 0x58F,
        /// <summary>
        /// Height must be less than 256.
        /// </summary>
        ERROR_INVALID_EDIT_HEIGHT = 0x590,
        /// <summary>
        /// Invalid device context (DC) handle.
        /// </summary>
        ERROR_DC_NOT_FOUND = 0x591,
        /// <summary>
        /// Invalid hook procedure type.
        /// </summary>
        ERROR_INVALID_HOOK_FILTER = 0x592,
        /// <summary>
        /// Invalid hook procedure.
        /// </summary>
        ERROR_INVALID_FILTER_PROC = 0x593,
        /// <summary>
        /// Cannot set nonlocal hook without a module handle.
        /// </summary>
        ERROR_HOOK_NEEDS_HMOD = 0x594,
        /// <summary>
        /// This hook procedure can only be set globally.
        /// </summary>
        ERROR_GLOBAL_ONLY_HOOK = 0x595,
        /// <summary>
        /// The journal hook procedure is already installed.
        /// </summary>
        ERROR_JOURNAL_HOOK_SET = 0x596,
        /// <summary>
        /// The hook procedure is not installed.
        /// </summary>
        ERROR_HOOK_NOT_INSTALLED = 0x597,
        /// <summary>
        /// Invalid message for single-selection list box.
        /// </summary>
        ERROR_INVALID_LB_MESSAGE = 0x598,
        /// <summary>
        /// LB_SETCOUNT sent to non-lazy list box.
        /// </summary>
        ERROR_SETCOUNT_ON_BAD_LB = 0x599,
        /// <summary>
        /// This list box does not support tab stops.
        /// </summary>
        ERROR_LB_WITHOUT_TABSTOPS = 0x59A,
        /// <summary>
        /// Cannot destroy object created by another thread.
        /// </summary>
        ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 0x59B,
        /// <summary>
        /// Child windows cannot have menus.
        /// </summary>
        ERROR_CHILD_WINDOW_MENU = 0x59C,
        /// <summary>
        /// The window does not have a system menu.
        /// </summary>
        ERROR_NO_SYSTEM_MENU = 0x59D,
        /// <summary>
        /// Invalid message box style.
        /// </summary>
        ERROR_INVALID_MSGBOX_STYLE = 0x59E,
        /// <summary>
        /// Invalid system-wide (SPI_*) parameter.
        /// </summary>
        ERROR_INVALID_SPI_VALUE = 0x59F,
        /// <summary>
        /// Screen already locked.
        /// </summary>
        ERROR_SCREEN_ALREADY_LOCKED = 0x5A0,
        /// <summary>
        /// All handles to windows in a multiple-window position structure must have the same parent.
        /// </summary>
        ERROR_HWNDS_HAVE_DIFF_PARENT = 0x5A1,
        /// <summary>
        /// The window is not a child window.
        /// </summary>
        ERROR_NOT_CHILD_WINDOW = 0x5A2,
        /// <summary>
        /// Invalid GW_* command.
        /// </summary>
        ERROR_INVALID_GW_COMMAND = 0x5A3,
        /// <summary>
        /// Invalid thread identifier.
        /// </summary>
        ERROR_INVALID_THREAD_ID = 0x5A4,
        /// <summary>
        /// Cannot process a message from a window that is not a multiple document interface (MDI) window.
        /// </summary>
        ERROR_NON_MDICHILD_WINDOW = 0x5A5,
        /// <summary>
        /// Popup menu already active.
        /// </summary>
        ERROR_POPUP_ALREADY_ACTIVE = 0x5A6,
        /// <summary>
        /// The window does not have scroll bars.
        /// </summary>
        ERROR_NO_SCROLLBARS = 0x5A7,
        /// <summary>
        /// Scroll bar range cannot be greater than MAXLONG.
        /// </summary>
        ERROR_INVALID_SCROLLBAR_RANGE = 0x5A8,
        /// <summary>
        /// Cannot show or remove the window in the way specified.
        /// </summary>
        ERROR_INVALID_SHOWWIN_COMMAND = 0x5A9,
        /// <summary>
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        ERROR_NO_SYSTEM_RESOURCES = 0x5AA,
        /// <summary>
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        ERROR_NONPAGED_SYSTEM_RESOURCES = 0x5AB,
        /// <summary>
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        ERROR_PAGED_SYSTEM_RESOURCES = 0x5AC,
        /// <summary>
        /// Insufficient quota to complete the requested service.
        /// </summary>
        ERROR_WORKING_SET_QUOTA = 0x5AD,
        /// <summary>
        /// Insufficient quota to complete the requested service.
        /// </summary>
        ERROR_PAGEFILE_QUOTA = 0x5AE,
        /// <summary>
        /// The paging file is too small for this operation to complete.
        /// </summary>
        ERROR_COMMITMENT_LIMIT = 0x5AF,
        /// <summary>
        /// A menu item was not found.
        /// </summary>
        ERROR_MENU_ITEM_NOT_FOUND = 0x5B0,
        /// <summary>
        /// Invalid keyboard layout handle.
        /// </summary>
        ERROR_INVALID_KEYBOARD_HANDLE = 0x5B1,
        /// <summary>
        /// Hook type not allowed.
        /// </summary>
        ERROR_HOOK_TYPE_NOT_ALLOWED = 0x5B2,
        /// <summary>
        /// This operation requires an interactive window station.
        /// </summary>
        ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 0x5B3,
        /// <summary>
        /// This operation returned because the timeout period expired.
        /// </summary>
        ERROR_TIMEOUT = 0x5B4,
        /// <summary>
        /// Invalid monitor handle.
        /// </summary>
        ERROR_INVALID_MONITOR_HANDLE = 0x5B5,
        /// <summary>
        /// Incorrect size argument.
        /// </summary>
        ERROR_INCORRECT_SIZE = 0x5B6,
        /// <summary>
        /// The symbolic link cannot be followed because its type is disabled.
        /// </summary>
        ERROR_SYMLINK_CLASS_DISABLED = 0x5B7,
        /// <summary>
        /// This application does not support the current operation on symbolic links.
        /// </summary>
        ERROR_SYMLINK_NOT_SUPPORTED = 0x5B8,
        /// <summary>
        /// Windows was unable to parse the requested XML data.
        /// </summary>
        ERROR_XML_PARSE_ERROR = 0x5B9,
        /// <summary>
        /// An error was encountered while processing an XML digital signature.
        /// </summary>
        ERROR_XMLDSIG_ERROR = 0x5BA,
        /// <summary>
        /// This application must be restarted.
        /// </summary>
        ERROR_RESTART_APPLICATION = 0x5BB,
        /// <summary>
        /// The caller made the connection request in the wrong routing compartment.
        /// </summary>
        ERROR_WRONG_COMPARTMENT = 0x5BC,
        /// <summary>
        /// There was an AuthIP failure when attempting to connect to the remote host.
        /// </summary>
        ERROR_AUTHIP_FAILURE = 0x5BD,
        /// <summary>
        /// Insufficient NVRAM resources exist to complete the requested service. A reboot might be required.
        /// </summary>
        ERROR_NO_NVRAM_RESOURCES = 0x5BE,
        /// <summary>
        /// Unable to finish the requested operation because the specified process is not a GUI process.
        /// </summary>
        ERROR_NOT_GUI_PROCESS = 0x5BF,
        /// <summary>
        /// The event log file is corrupted.
        /// </summary>
        ERROR_EVENTLOG_FILE_CORRUPT = 0x5DC,
        /// <summary>
        /// No event log file could be opened, so the event logging service did not start.
        /// </summary>
        ERROR_EVENTLOG_CANT_START = 0x5DD,
        /// <summary>
        /// The event log file is full.
        /// </summary>
        ERROR_LOG_FILE_FULL = 0x5DE,
        /// <summary>
        /// The event log file has changed between read operations.
        /// </summary>
        ERROR_EVENTLOG_FILE_CHANGED = 0x5DF,
        /// <summary>
        /// The specified task name is invalid.
        /// </summary>
        ERROR_INVALID_TASK_NAME = 0x60E,
        /// <summary>
        /// The specified task index is invalid.
        /// </summary>
        ERROR_INVALID_TASK_INDEX = 0x60F,
        /// <summary>
        /// The specified thread is already joining a task.
        /// </summary>
        ERROR_THREAD_ALREADY_IN_TASK = 0x610,
        /// <summary>
        /// The Windows Installer Service could not be accessed. This can occur if the Windows Installer is not correctly installed. Contact your support personnel for assistance.
        /// </summary>
        ERROR_INSTALL_SERVICE_FAILURE = 0x641,
        /// <summary>
        /// User cancelled installation.
        /// </summary>
        ERROR_INSTALL_USEREXIT = 0x642,
        /// <summary>
        /// Fatal error during installation.
        /// </summary>
        ERROR_INSTALL_FAILURE = 0x643,
        /// <summary>
        /// Installation suspended, incomplete.
        /// </summary>
        ERROR_INSTALL_SUSPEND = 0x644,
        /// <summary>
        /// This action is only valid for products that are currently installed.
        /// </summary>
        ERROR_UNKNOWN_PRODUCT = 0x645,
        /// <summary>
        /// Feature ID not registered.
        /// </summary>
        ERROR_UNKNOWN_FEATURE = 0x646,
        /// <summary>
        /// Component ID not registered.
        /// </summary>
        ERROR_UNKNOWN_COMPONENT = 0x647,
        /// <summary>
        /// Unknown property.
        /// </summary>
        ERROR_UNKNOWN_PROPERTY = 0x648,
        /// <summary>
        /// Handle is in an invalid state.
        /// </summary>
        ERROR_INVALID_HANDLE_STATE = 0x649,
        /// <summary>
        /// The configuration data for this product is corrupt. Contact your support personnel.
        /// </summary>
        ERROR_BAD_CONFIGURATION = 0x64A,
        /// <summary>
        /// Component qualifier not present.
        /// </summary>
        ERROR_INDEX_ABSENT = 0x64B,
        /// <summary>
        /// The installation source for this product is not available. Verify that the source exists and that you can access it.
        /// </summary>
        ERROR_INSTALL_SOURCE_ABSENT = 0x64C,
        /// <summary>
        /// This installation package cannot be installed by the Windows Installer service. You must install a Windows 
        /// service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        ERROR_INSTALL_PACKAGE_VERSION = 0x64D,
        /// <summary>
        /// Product is uninstalled.
        /// </summary>
        ERROR_PRODUCT_UNINSTALLED = 0x64E,
        /// <summary>
        /// SQL query syntax invalid or unsupported.
        /// </summary>
        ERROR_BAD_QUERY_SYNTAX = 0x64F,
        /// <summary>
        /// Record field does not exist.
        /// </summary>
        ERROR_INVALID_FIELD = 0x650,
        /// <summary>
        /// The device has been removed.
        /// </summary>
        ERROR_DEVICE_REMOVED = 0x651,
        /// <summary>
        /// Another installation is already in progress. Complete that installation before proceeding with this install.
        /// </summary>
        ERROR_INSTALL_ALREADY_RUNNING = 0x652,
        /// <summary>
        /// This installation package could not be opened. Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        ERROR_INSTALL_PACKAGE_OPEN_FAILED = 0x653,
        /// <summary>
        /// This installation package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        ERROR_INSTALL_PACKAGE_INVALID = 0x654,
        /// <summary>
        /// There was an error starting the Windows Installer service user interface. Contact your support personnel.
        /// </summary>
        ERROR_INSTALL_UI_FAILURE = 0x655,
        /// <summary>
        /// Error opening installation log file. Verify that the specified log file location exists and that you can write to it.
        /// </summary>
        ERROR_INSTALL_LOG_FAILURE = 0x656,
        /// <summary>
        /// The language of this installation package is not supported by your system.
        /// </summary>
        ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 0x657,
        /// <summary>
        /// Error applying transforms. Verify that the specified transform paths are valid.
        /// </summary>
        ERROR_INSTALL_TRANSFORM_FAILURE = 0x658,
        /// <summary>
        /// This installation is forbidden by system policy. Contact your system administrator.
        /// </summary>
        ERROR_INSTALL_PACKAGE_REJECTED = 0x659,
        /// <summary>
        /// Function could not be executed.
        /// </summary>
        ERROR_FUNCTION_NOT_CALLED = 0x65A,
        /// <summary>
        /// Function failed during execution.
        /// </summary>
        ERROR_FUNCTION_FAILED = 0x65B,
        /// <summary>
        /// Invalid or unknown table specified.
        /// </summary>
        ERROR_INVALID_TABLE = 0x65C,
        /// <summary>
        /// Data supplied is of wrong type.
        /// </summary>
        ERROR_DATATYPE_MISMATCH = 0x65D,
        /// <summary>
        /// Data of this type is not supported.
        /// </summary>
        ERROR_UNSUPPORTED_TYPE = 0x65E,
        /// <summary>
        /// The Windows Installer service failed to start. Contact your support personnel.
        /// </summary>
        ERROR_CREATE_FAILED = 0x65F,
        /// <summary>
        /// The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or verify that you  have write permission on the Temp folder.
        /// </summary>
        ERROR_INSTALL_TEMP_UNWRITABLE = 0x660,
        /// <summary>
        /// This installation package is not supported by this processor type. Contact your product vendor.
        /// </summary>
        ERROR_INSTALL_PLATFORM_UNSUPPORTED = 0x661,
        /// <summary>
        /// Component not used on this computer.
        /// </summary>
        ERROR_INSTALL_NOTUSED = 0x662,
        /// <summary>
        /// This update package could not be opened. Verify that the update package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer update package.
        /// </summary>
        ERROR_PATCH_PACKAGE_OPEN_FAILED = 0x663,
        /// <summary>
        /// This update package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer update package.
        /// </summary>
        ERROR_PATCH_PACKAGE_INVALID = 0x664,
        /// <summary>
        /// This update package cannot be processed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        ERROR_PATCH_PACKAGE_UNSUPPORTED = 0x665,
        /// <summary>
        /// Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.
        /// </summary>
        ERROR_PRODUCT_VERSION = 0x666,
        /// <summary>
        /// Invalid command line argument. Consult the Windows Installer SDK for detailed command line help.
        /// </summary>
        ERROR_INVALID_COMMAND_LINE = 0x667,
        /// <summary>
        /// Only administrators have permission to add, remove, or configure server software during a Terminal services remote session. If you want to install or configure software on the server, contact your network administrator.
        /// </summary>
        ERROR_INSTALL_REMOTE_DISALLOWED = 0x668,
        /// <summary>
        /// The requested operation completed successfully. The system will be restarted so the changes can take effect.
        /// </summary>
        ERROR_SUCCESS_REBOOT_INITIATED = 0x669,
        /// <summary>
        /// The upgrade cannot be installed by the Windows Installer service because the program to be upgraded may be missing, or the upgrade may update a different version of the program. Verify that the program to be upgraded 
        /// exists on your computer and that you have the correct upgrade.
        /// </summary>
        ERROR_PATCH_TARGET_NOT_FOUND = 0x66A,
        /// <summary>
        /// The update package is not permitted by software restriction policy.
        /// </summary>
        ERROR_PATCH_PACKAGE_REJECTED = 0x66B,
        /// <summary>
        /// One or more customizations are not permitted by software restriction policy.
        /// </summary>
        ERROR_INSTALL_TRANSFORM_REJECTED = 0x66C,
        /// <summary>
        /// The Windows Installer does not permit installation from a Remote Desktop Connection.
        /// </summary>
        ERROR_INSTALL_REMOTE_PROHIBITED = 0x66D,
        /// <summary>
        /// Uninstallation of the update package is not supported.
        /// </summary>
        ERROR_PATCH_REMOVAL_UNSUPPORTED = 0x66E,
        /// <summary>
        /// The update is not applied to this product.
        /// </summary>
        ERROR_UNKNOWN_PATCH = 0x66F,
        /// <summary>
        /// No valid sequence could be found for the set of updates.
        /// </summary>
        ERROR_PATCH_NO_SEQUENCE = 0x670,
        /// <summary>
        /// Update removal was disallowed by policy.
        /// </summary>
        ERROR_PATCH_REMOVAL_DISALLOWED = 0x671,
        /// <summary>
        /// The XML update data is invalid.
        /// </summary>
        ERROR_INVALID_PATCH_XML = 0x672,
        /// <summary>
        /// Windows Installer does not permit updating of managed advertised products. At least one feature of the product must be installed before applying the update.
        /// </summary>
        ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT = 0x673,
        /// <summary>
        /// The Windows Installer service is not accessible in Safe Mode. Please try again when your computer is not in Safe Mode or you can use System Restore to return your machine to a previous good state.
        /// </summary>
        ERROR_INSTALL_SERVICE_SAFEBOOT = 0x674,
        /// <summary>
        /// A fail fast exception occurred. Exception handlers will not be invoked and the process will be terminated immediately.
        /// </summary>
        ERROR_FAIL_FAST_EXCEPTION = 0x675,
        /// <summary>
        /// The app that you are trying to run is not supported on this version of Windows.
        /// </summary>
        ERROR_INSTALL_REJECTED = 0x676,

        #endregion

        #region 1700 - 3999

        #endregion
    }
}
