# DesignKata-CodeWars-Maximum-Time

https://www.codewars.com/kata/62a4abf03236976b7acf7781

Problem:

Given an array of digits (could be any size), find the maximum 24-hour time "hh:mm" that can be made, each digits can be used exactly once on Hour or on Minute separately.

### Please see Example 1, Example 2, and Example 3


### Return the latest 24-hour time in "HH:MM" format. If no valid time can be made, return "-1".

---------------------------------EXAMPLES------------------------------------------------

+Example 1 (See the next example):

Input: inputArray = {1,2,3,4}

Output: "23:43"

*Explanation: The valid 24-hour times are "12:34", "12:43", "13:24", "13:42", "14:23", "14:32", "21:34", "21:43", "23:14", and "23:41". Of these times, "23:43" is the latest.

-----------------------------------------------------------------------------------------

+Example 2:

Input: inputArray = {1,2,3,4,4}

Output: "23:44"

*Explanation: Now we have another "4" that can be used in the Minutes.

-----------------------------------------------------------------------------------------

+Example 3:

Input: inputArray = {5,5,5}

Output: "-1"

*Explanation: We don't have "0" or "1", to create "15" or "05" for "Hour".

-----------------------------------------------------------------------------------------

+Example 4:

Input: inputArray = {0,0,0,0}

Output: "00:00"

-----------------------------------------------------------------------------------------

+Example 5:

Input: arr = {0,1}

Output: "10:10"

-----------------------------------------------------------------------------------------

+Example 6:

input: inputArray = {0,1,1}

Output: "11:11"
