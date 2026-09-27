using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLog.Targets.Dispatchers
{
    internal interface IDispatcher
    {
        /// <summary>
        /// Initial setup for a <see cref="IDispatcher"/> instance.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="dueTime">
        /// The amount of time to delay before the invoking the callback method specified
        /// when the <see cref="Set(Action, int, int)"/> method was called, in milliseconds. Specify a negative number
        /// to prevent the timer from restarting. Specify zero (0) to restart the timer immediately.
        /// </param>
        /// <param name="period">
        /// The time interval between invocations of the callback method specified when the
        /// IDispatcher instance was constructed, in milliseconds. Specify a negative number
        /// to disable periodic signaling.
        /// </param>
        /// <returns>true if the setup was successful, otherwise false.</returns>
        public bool Set(Action callback, int dueTime, int period);

        /// <summary>
        /// Changes the start time and the interval between method invocations for a <see cref="IDispatcher"/>,
        /// using 32-bit signed integers to measure time intervals.
        /// </summary>
        /// <param name="dueTime">
        /// The amount of time to delay before the invoking the callback method specified
        /// when the <see cref="Set(Action, int, int)"/> method was called, in milliseconds. Specify a negative number
        /// to prevent the timer from restarting. Specify zero (0) to restart the timer immediately.
        /// </param>
        /// <param name="period">
        /// The time interval between invocations of the callback method specified when the
        /// IDispatcher instance was constructed, in milliseconds. Specify a negative number
        /// to disable periodic signaling.
        /// </param>
        /// <returns>true if the change was successful, otherwise false.</returns>
        public bool Change(int dueTime, int period);
    }
}
