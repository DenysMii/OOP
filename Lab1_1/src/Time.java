import java.time.format.DateTimeFormatter;
import java.time.LocalDateTime;

public class Time {
    static void printTime(){
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd/MM/yyyy HH:mm:ss");
        LocalDateTime now = LocalDateTime.now();
        System.out.println(dtf.format(now));
    }

}
