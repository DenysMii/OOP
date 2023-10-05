public class Main {
    public static void main(String[] args) {

        Person person;

        person = new Italian();
        person.PrintCountryName();
        person.Speak();

        person = new Ukrainian();
        person.PrintCountryName();
        person.Speak();
    }
}