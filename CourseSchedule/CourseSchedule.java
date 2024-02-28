import java.util.Map;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

class CourseSchedule {
    public static void main(String[] args) {
        int[][] preCourse = new int[4][2];
        preCourse[0][0] = 1;
        preCourse[0][1] = 4;
        preCourse[1][0] = 2;
        preCourse[1][1] = 4;
        preCourse[2][0] = 3;
        preCourse[2][1] = 1;
        preCourse[3][0] = 3;
        preCourse[3][1] = 2;

        System.out.println(canFinish(5, preCourse));
    }

    public static boolean canFinish(int numCourses, int[][] prerequisites) 
    {
        if (prerequisites.length == 0)
            return true;
        
        Map<Integer, Integer> memo = new HashMap<Integer, Integer>();
        List<Integer> tookCourse = new ArrayList<Integer>();
        int countCourse = numCourses;

        for (int[] pCourse : prerequisites) 
        {
            memo.put(pCourse[0], pCourse[1]);
        }

        for (Map.Entry<Integer, Integer> pCourse : memo.entrySet()) 
        {
            // [[1,4],[2,4],[3,1],[3,2]]

            Integer targetCourse = pCourse.getKey();
            
            if (tookCourse.contains(memo.get(targetCourse))) 
                continue;

            tookCourse.add(targetCourse); // add key
            System.out.println("Add - " + targetCourse);
            countCourse--;

            do 
            {
                targetCourse = memo.get(targetCourse); // get old key's value
                tookCourse.add(targetCourse); // add key
                System.out.println("Add - " + targetCourse);
                countCourse--;

                if (targetCourse != null && tookCourse.contains(memo.get(targetCourse)) || memo.get(targetCourse) == null)
                    break;
                if (targetCourse == null && countCourse == 0)
                    return true;
                else if (targetCourse == null) // check if new key already found
                    break;
                

            } while (countCourse > 0);

            if (countCourse >= 0)
                return true;
        }
        return false;
    }
}